using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoCaixasEntradas(DbContext dbContext)
    : ServicoEntidades<CaixaEntrada>(dbContext), IServicoCaixasEntradas
{
    public virtual CaixaEntrada CancelarEntrada(
        long entradaCaixaId,
        string motivoCancelamento)
    {
        var entradaCaixa = ObterPorId(entradaCaixaId, true) ??
                           throw new InvalidOperationException("A saida já foi cancelada");
        ;

        entradaCaixa.FoiCancelada = true;
        entradaCaixa.CanceladaEm = DateTime.Now;
        entradaCaixa.MotivoCancelamento = motivoCancelamento;

        Editar(entradaCaixa);
        SalvarAlteracoes();

        return entradaCaixa;
    }

    public virtual CaixaEntrada? ObterPorId(
        long id,
        bool usarRastreamento = false,
        bool incluirPropriedadeCaixa = false)
    {
        var query = DbContext.Set<CaixaEntrada>()
            .AsQueryable();

        if (incluirPropriedadeCaixa)
            query = query.Include(entradaCaixa => entradaCaixa.Caixa);

        return query.PrimeiroOuPadrao(entradaCaixa => entradaCaixa.Id == id, usarRastreamento);
    }
}