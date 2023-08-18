using AutoMapper;

using Microsoft.EntityFrameworkCore;

using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Data.Servicos
{
    public class ServicoClientes : IServicoClientes
    {
        private readonly WZSISTEMASDbContext dbContext;
        private readonly IMapper mapper;

        public ServicoClientes(WZSISTEMASDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, Cliente>();
            }).CreateMapper();
        }

        public async Task CriarAsync(Cliente cadastro)
        {
            await dbContext.AddAsync(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Cliente?> ObterPorIdAsync(long id)
        {
            return await dbContext.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Cliente?> ObterPorCPF_CNPJAsync(string cPF_CNPJ)
        {
            return await dbContext.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.CPF_CNPJ == cPF_CNPJ);
        }

        public async Task EditarAsync(Cliente cadastro)
        {
            var cadastroEncontrado = await dbContext.Clientes
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
            var cadastro = await dbContext.Clientes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cadastro is null)
                throw new InvalidOperationException("O cadastro não foi encontrado");

            dbContext.Remove(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cliente>> ObterPorNomeCompleto_RazaoSocialAsync(string nomeCompleto_RazaoSocial)
        {
            return await dbContext.Clientes
                .AsNoTracking()
                .Where(x => x.NomeCompleto_RazaoSocial.Contains(nomeCompleto_RazaoSocial))
                .ToListAsync();
        }
    }
}
