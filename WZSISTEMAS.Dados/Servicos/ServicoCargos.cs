using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoCargos(
    DbContext dbContext,
    IValidator<Cargo> validacao)
    : ServicoEntidades<Cargo>(dbContext),
        IServicoCargos,
        IServicoEntidadesListarItens<Cargo>,
        IServicoValidacaoEntidades<Cargo>
{
    private readonly IValidator<Cargo> validacao = validacao
                                                   ?? throw new ArgumentNullException(nameof(validacao));

    public virtual IEnumerable<Cargo> ObterTudoPorNome(string nome)
    {
        return DbContext.Set<Cargo>()
            .ObterLista(
                cargo => cargo.Nome.Contains(nome));
    }

    public virtual ValidationResult Validar(Cargo entidade)
    {
        return validacao.Validate(entidade);
    }

    protected override Expression<Func<Cargo, ItemLista<long>>> ConverterEntidadeParaLista()
    {
        return cargo => new ItemLista<long>
        {
            Item = cargo.Id,
            Descricao = cargo.Nome
        };
    }
}