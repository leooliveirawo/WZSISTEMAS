using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoEntradas(DbContext dbContext) : ServicoEntidades<Entrada>(dbContext), IServicoEntradas
{
}