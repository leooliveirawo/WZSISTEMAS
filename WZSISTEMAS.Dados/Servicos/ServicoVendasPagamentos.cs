using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoVendasPagamentos(DbContext dbContext)
    : ServicoEntidades<VendaPagamento>(dbContext), IServicoVendasPagamentos
{
}