using AutoMapper;

using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Data.Servicos
{
    public class ServicoFuncionarios : IServicoFuncionarios
    {
        private readonly WZSISTEMASDbContext dbContext;
        private readonly IMapper mapper;

        public ServicoFuncionarios(WZSISTEMASDbContext dbContext)
        {
            this.dbContext = dbContext;

            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Funcionario, Funcionario>();
            }).CreateMapper();
        }

        public async Task CriarAsync(Funcionario cadastro)
        {
            await dbContext.AddAsync(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync(Funcionario cadastro)
        {
            var cadastroEncontrado = await dbContext.Funcionarios
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
            var cadastro = await dbContext.Funcionarios
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cadastro is null)
                throw new InvalidOperationException("O cadastro não foi encontrado");

            dbContext.Remove(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Funcionario?> ObterPorCPFAsync(string cPF)
        {
            return await dbContext.Funcionarios
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.CPF == cPF);
        }

        public async Task<Funcionario?> ObterPorIdAsync(long id)
        {
            return await dbContext.Funcionarios
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Funcionario>> ObterPorNomeCompletoAsync(string nomeCompleto)
        {
            return await dbContext.Funcionarios
                .AsNoTracking()
                .Where(x => x.NomeCompleto.Contains(nomeCompleto))
                .ToListAsync();
        }
    }
}
