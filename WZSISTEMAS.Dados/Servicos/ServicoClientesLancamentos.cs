using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoClientesLancamentos(
    DbContext dbContext,
    IServicoClientesFaturas servicoClientesFaturas,
    IServicoClientes servicoClientes)
    : ServicoEntidades<ClienteLancamento>(dbContext), IServicoClientesLancamentos
{
    private readonly IServicoClientes servicoClientes = servicoClientes
                                                        ?? throw new ArgumentNullException(nameof(servicoClientes));

    private readonly IServicoClientesFaturas servicoClientesFaturas = servicoClientesFaturas
                                                                      ?? throw new ArgumentNullException(
                                                                          nameof(servicoClientesFaturas));

    public virtual ClienteLancamento Criar(
        long clienteId,
        long vendaPagamentoId,
        decimal valorTitulo,
        Mes mesReferente,
        int anoReferentes)
    {
        var cliente = servicoClientes.ObterPorId(clienteId, true)
                      ?? throw new InvalidOperationException("O cliente não foi encontrado");

        var fatura = servicoClientesFaturas.ObterPorClienteId(
            clienteId,
            mesReferente,
            anoReferentes,
            true);

        var entidade = new ClienteLancamento
        {
            VendaPagamentoId = vendaPagamentoId,
            LancadoEm = DateTime.Now,
            ValorLancamento = valorTitulo,
            ValorRestante = valorTitulo
        };

        if (fatura is null)
        {
            fatura = new ClienteFatura
            {
                ClienteId = clienteId,
                ValorFatura = entidade.ValorLancamento,
                ValorRestante = entidade.ValorLancamento,
                DiaFechamentoVencimento = cliente.FaturaDiaFechamentoVencimento,
                MesReferente = mesReferente,
                AnoReferente = anoReferentes
            };

            entidade.Fatura = fatura;

            servicoClientesFaturas.Criar(fatura);
        }
        else
        {
            if (fatura.ValorRestante < entidade.ValorLancamento)
                throw new InvalidOperationException("Não há saldo suficiente");

            entidade.FaturaId = fatura.Id;

            fatura.ValorFatura += entidade.ValorLancamento;
            fatura.ValorRestante += entidade.ValorLancamento;

            servicoClientesFaturas.Editar(fatura);
        }

        cliente.ConvenioLimiteDisponivel -= valorTitulo;
        cliente.ConvenioLimiteUsado += valorTitulo;

        servicoClientes.Editar(cliente);

        Criar(entidade);

        return entidade;
    }

    public virtual ClienteLancamento Criar(
        long clienteId,
        long vendaPagamentoId,
        decimal valorTitulo)
    {
        var dataAtual = DateTime.Now;
        var cliente = servicoClientes.ObterPorId(clienteId)
                      ?? throw new InvalidOperationException("O cliente não foi encontrado");

        var novaData = new DateTime(
            dataAtual.Year,
            dataAtual.Month,
            cliente.FaturaDiaFechamentoVencimento.ObterDiaFechamento());

        if (dataAtual.Day >= novaData.Day)
            novaData = novaData.AddMonths(1);

        return Criar(
            clienteId,
            vendaPagamentoId,
            valorTitulo,
            (Mes)novaData.Month,
            novaData.Year);
    }

    public virtual IEnumerable<ClienteLancamento> CriarVarios(long clienteId, long vendaPagamentoId,
        decimal valorTitulo, int quantidade)
    {
        var dataAtual = DateTime.Now;
        var cliente = servicoClientes.ObterPorId(clienteId)
                      ?? throw new InvalidOperationException("O cliente não foi encontrado");

        var novaData = new DateTime(
            dataAtual.Year,
            dataAtual.Month,
            cliente.FaturaDiaFechamentoVencimento.ObterDiaFechamento());

        if (dataAtual.Day >= novaData.Day)
            novaData = novaData.AddMonths(1);

        var titulos = new List<ClienteLancamento>();

        var valor = valorTitulo / quantidade;

        for (var i = 0; i < quantidade; i++)
        {
            titulos.Add(
                Criar(
                    clienteId,
                    vendaPagamentoId,
                    valor,
                    (Mes)novaData.Month,
                    novaData.Year));

            novaData = novaData.AddMonths(1);
        }

        return titulos;
    }

    public virtual IEnumerable<ClienteLancamento> ObterTudoPorClienteId(
        long clienteId,
        Mes mesReferente,
        int anoReferente)
    {
        return DbContext.Set<ClienteLancamento>()
            .AsNoTracking()
            .Where(x
                => x.Fatura.ClienteId == clienteId
                   && x.Fatura.MesReferente == mesReferente
                   && x.Fatura.AnoReferente == anoReferente)
            .ToList();
    }

    public virtual void RealizarPagamento(
        long clienteId,
        decimal valorPago,
        Mes mesReferente,
        int anoReferente)
    {
        var titulos =
            DbContext.Set<ClienteLancamento>()
                .Where(x
                    => !x.Pago
                       || x.ParcialmentePago)
                .ToList();

        var valorRestante = valorPago;

        foreach (var titulo in titulos)
            if (valorRestante >= titulo.ValorRestante)
            {
                valorRestante -= titulo.ValorRestante;

                titulo.ValorRestante = 0;
                titulo.ValorPago = titulo.ValorLancamento;
                titulo.Pago = true;
            }
            else if (valorRestante != 0)
            {
                titulo.ValorRestante -= valorRestante;
                titulo.ValorPago += valorRestante;
                titulo.ParcialmentePago = true;

                valorRestante = 0;
            }
            else
            {
                break;
            }
    }

    public virtual bool VerificarLancamentosEmAberto(long clienteId)
    {
        return DbContext.Set<ClienteLancamento>()
            .AsNoTracking()
            .Where(x => x.Fatura.ClienteId == clienteId
                        && !x.Pago
                        && !x.ParcialmentePago)
            .Select(x => x.Id)
            .Any();
    }

    public virtual bool VerificarLimite(long clienteId, decimal valor)
    {
        var retorno = DbContext.Set<Cliente>()
            .AsNoTracking()
            .Include(x => x.Faturas)
            .Where(x => x.Id == clienteId)
            .Select(x => new
            {
                Limite = x.ConvenioLimite,
                Titulos = x.Faturas
                    .Where(y => y.ClienteId == clienteId
                                && !y.Pago
                                && !y.ParcialmentePago)
                    .Select(x => new
                    {
                        x.ValorRestante
                    })
            })
            .FirstOrDefault() ?? throw new InvalidOperationException("O cliente não foi encontrado");

        var valorTotal = 0m;

        foreach (var titulo in retorno.Titulos)
            valorTotal += titulo.ValorRestante;

        var valorRestante = retorno.Limite - valorTotal;

        return valorRestante >= valor;
    }
}