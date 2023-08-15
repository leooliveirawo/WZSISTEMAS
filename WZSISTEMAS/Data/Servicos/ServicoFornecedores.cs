using AutoMapper;

using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Data.Servicos
{
    public class ServicoFornecedores : IServicoFornecedores
    {
        private readonly WZSISTEMASDbContext dbContext;
        private readonly IMapper mapper;

        public ServicoFornecedores(WZSISTEMASDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Fornecedor, Fornecedor>();
            }).CreateMapper();
        }

        public async Task CriarAsync(Fornecedor cadastro)
        {
            await dbContext.AddAsync(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Fornecedor?> ObterPorIdAsync(long id)
        {
            return await dbContext.Fornecedores
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<Fornecedor?> ObterPorCNPJAsync(string cNPJ)
        {
            return await dbContext.Fornecedores
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.CNPJ == cNPJ);

        }

        public async Task EditarAsync(Fornecedor cadastro)
        {
            var cadastroEncontrado = await dbContext.Fornecedores
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == cadastro.Id);

            if (cadastroEncontrado is null)
                throw new InvalidOperationException("O cadastro não foi encontrado");

            mapper.Map(cadastro, cadastroEncontrado);


            dbContext.Update(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task ExcluirAsync(long id)
        {
            var cadastro = await dbContext.Fornecedores
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cadastro is null)
                throw new InvalidOperationException("O cadastro não foi encontrado");

            dbContext.Remove(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Fornecedor>> ObterPorRazaoSocialAsync(string razaoSocial)
        {
            return await dbContext.Fornecedores
                .AsNoTracking()
                .Where(x => x.RazaoSocial.Contains(razaoSocial))
                .ToListAsync();
        }
    }
}
