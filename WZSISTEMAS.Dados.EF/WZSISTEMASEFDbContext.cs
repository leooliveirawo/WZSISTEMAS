using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Base.EF.Valores;
using WZSISTEMAS.Dados.Entidades;

namespace WZSISTEMAS.Dados.EF;

public class WZSISTEMASEFDbContext : DbContext
{
    public DbSet<Caixa> Caixas { get; set; }
    public DbSet<CaixaEntrada> CaixasEntradas { get; set; }
    public DbSet<CaixaSaida> CaixasSaidas { get; set; }
    public DbSet<CaixaSuprimento> CaixasSuprimentos { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ClienteLancamento> ClientesLancamentos { get; set; }
    public DbSet<ClienteFatura> ClientesFaturas { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Entrada> Entradas { get; set; }
    public DbSet<EntradaItem> EntradasItens { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Item> Itens { get; set; }
    public DbSet<Terminal> Terminais { get; set; }
    public DbSet<Transportadora> Transportadoras { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<VendaItem> VendasItens { get; set; }
    public DbSet<VendaPagamento> VendasPagamentos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoItem> PedidosItens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(ConfiguracoesConexao.ConnectionString, opt => { opt.EnableRetryOnFailure(); });

        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(WZSISTEMASDbContext)));
    }
}