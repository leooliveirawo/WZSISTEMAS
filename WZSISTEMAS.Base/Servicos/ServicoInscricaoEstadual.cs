using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoInscricaoEstadual(IServicoRandomico servicoRandomico) : IServicoInscricaoEstadual
{
    private readonly IServicoRandomico servicoRandomico = servicoRandomico
        ?? throw new ArgumentNullException(nameof(servicoRandomico));

    public virtual string Gerar()
        => servicoRandomico.GerarRandomicamente(14);
}
