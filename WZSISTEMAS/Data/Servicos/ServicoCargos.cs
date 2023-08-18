using AutoMapper;

﻿using Microsoft.EntityFrameworkCore;

using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Data.Servicos
{
    public class ServicoCargos : IServicoCargos
    {
        private readonly WZSISTEMASDbContext dbContext;

        private readonly IMapper mapper;

        public ServicoCargos(WZSISTEMASDbContext dbContext)
        {
            this.dbContext = dbContext;

            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cargo, Cargo>();
            }).CreateMapper();
        }

        public async Task CriarAsync(Cargo cadastro)
        {
            await dbContext.AddAsync(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync(Cargo cadastro)
        {
            var cadastroEncontrado = await dbContext.Cargos
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
            var cadastro = await dbContext.Cargos
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cadastro is null)
                throw new InvalidOperationException("O cadastro não foi encontrado");

            dbContext.Remove(cadastro);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cargo>> ListarAsync()
        {
            return await dbContext.Cargos
                .AsNoTracking()
                .ToListAsync();
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
