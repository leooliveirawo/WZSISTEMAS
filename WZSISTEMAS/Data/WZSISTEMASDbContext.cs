using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Data
{
    public class WZSISTEMASDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leool\source\repos\WZSISTEMAS\WZSISTEMAS\Data\Db.mdf;Integrated Security=True");
        }
    }
}
