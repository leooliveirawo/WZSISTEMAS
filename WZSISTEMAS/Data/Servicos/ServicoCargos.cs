using Microsoft.EntityFrameworkCore;

using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Data.Servicos
{
    public class ServicoCargos : IServicoCargos
    {
        private readonly WZSISTEMASDbContext dbContext;

        public ServicoCargos(WZSISTEMASDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CriarAsync(Cargo cadastro)
        {
            await dbContext.AddAsync(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync(Cargo cadastro)
        {
            dbContext.Update(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task ExcluirAsync(long id)
        {
            var cadastro = await dbContext.Cargos
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cadastro is null)
                throw new InvalidOperationException("O cadastro não foi encontrado");

            dbContext.Remove(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Cargo?> ObterPorIdAsync(long id)
        {
            return await dbContext.Cargos
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Cargo>> ObterPorNomeAsync(string nome)
        {
            return await dbContext.Cargos
                .AsNoTracking()
                .Where(x => x.Nome.Contains(nome))
                .ToListAsync();
        }
    }
}
