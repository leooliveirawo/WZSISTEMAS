using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoCaixasSaidas(DbContext dbContext)
    : ServicoEntidades<CaixaSaida>(dbContext), IServicoCaixasSaidas
{
    public virtual CaixaSaida? ObterPeloId(
        long id,
        bool usarRastreamento = false,
        bool incluirPropriedadeCaixa = false)
    {
        var query = DbContext.Set<CaixaSaida>()
            .AsQueryable();

        if (incluirPropriedadeCaixa)
            query = query.Include(x => x.Caixa);

        return query.PrimeiroOuPadrao(saidaCaixa => saidaCaixa.Id == id, usarRastreamento);
    }
}