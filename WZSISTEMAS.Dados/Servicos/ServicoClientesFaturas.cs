using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoClientesFaturas(DbContext dbContext)
    : ServicoEntidades<ClienteFatura>(dbContext), IServicoClientesFaturas
{
    public virtual ClienteFatura? ObterPorClienteId(long clienteId, Mes mesReferente,
        int anoReferentes, bool usarTracking = false, bool incluirLancamentos = false, bool incluirCliente = false)
    {
        var query = DbContext.Set<ClienteFatura>().AsQueryable();

        if (!usarTracking)
            query = query.AsNoTracking();

        if (incluirLancamentos)
            query = query.Include(x => x.Lancamentos);

        if (incluirCliente)
            query = query.Include(x => x.Cliente);

        return query
            .FirstOrDefault(
                x => x.ClienteId == clienteId
                     && x.MesReferente == mesReferente
                     && x.AnoReferente == anoReferentes);
    }

    public virtual ClienteFatura? ObterPorId(
        long id,
        bool usarTracking = false,
        bool incluirLancamentos = false,
        bool incluirCliente = false)
    {
        var query = DbContext.Set<ClienteFatura>()
            .AsNoTracking();

        if (!usarTracking)
            query = query.AsNoTracking();

        if (incluirLancamentos)
            query = query.Include(x => x.Lancamentos);

        if (incluirCliente)
            query = query.Include(x => x.Cliente);

        return query.FirstOrDefault(x => x.Id == id);
    }

    ClienteFatura? IServicoClientesFaturas.ListarPorClienteId(long clienteId, bool incluirLancamentos,
        bool incluirCliente)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<ClienteFatura> ListarPorClienteId(
        long clienteId,
        bool incluirLancamentos = false,
        bool incluirCliente = false)
    {
        var query = DbContext.Set<ClienteFatura>()
            .AsNoTracking();

        if (incluirLancamentos)
            query = query.Include(x => x.Lancamentos);

        if (incluirCliente)
            query = query.Include(x => x.Cliente);

        return query
            .Where(x => x.ClienteId == clienteId)
            .ToList();
    }
}