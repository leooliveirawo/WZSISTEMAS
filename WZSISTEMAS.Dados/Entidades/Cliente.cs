namespace WZSISTEMAS.Dados.Entidades;

public class Cliente : Entidade, IEnderecoCompleto
{
    public TipoCliente Tipo { get; set; }
    public string NomeCompleto_RazaoSocial { get; set; } = default!;
    public string CPF_CNPJ { get; set; } = default!;
    public string? RG_INSCRICAO_ESTADUAL { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string? Referencia { get; set; }

    public bool ConvenioAtivo { get; set; }
    public bool ConvenioInativo { get; set; }
    public bool ConvenioBloqueado { get; set; }
    public decimal? ConvenioLimite { get; set; }
    public decimal? ConvenioLimiteDisponivel { get; set; }
    public decimal? ConvenioLimiteUsado { get; set; }

    public ICollection<ClienteFatura> Faturas { get; set; }
        = new HashSet<ClienteFatura>();

    public DiaDeFechamentoEVencimento FaturaDiaFechamentoVencimento { get; set; }
        = DiaDeFechamentoEVencimento.Dia1_8;

    public string Logradouro { get; set; } = default!;
    public string? LogradouroNumero { get; set; }
    public string? Complemento { get; set; }

    public string CEP { get; set; } = default!;
    public string Bairro { get; set; } = default!;
    public string Cidade { get; set; } = default!;
    public UFs UF { get; set; } = default!;
    public string? Pais { get; set; }

    public string? Telefone { get; set; }
    public string? Telefone2 { get; set; }
    public string? Telefone3 { get; set; }

    public string? Email { get; set; }
}