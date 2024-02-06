using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Base.EF.Helpers;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoCaixasSuprimentos(
    DbContext dbContext)
    : ServicoEntidades<CaixaSuprimento>(dbContext), IServicoCaixasSuprimentos
{
    public virtual CaixaSuprimento? ObterPeloId(
        long id,
        bool usarRastreamento = false,
        bool incluirPropriedadeCaixa = false)
    {
        var query = DbContext.Set<CaixaSuprimento>()
            .AsQueryable();

        if (incluirPropriedadeCaixa)
            query = query.Include(suprimentoCaixa => suprimentoCaixa.Caixa);

        return query.PrimeiroOuPadrao(entity => entity.Id == id, usarRastreamento);
    }
}