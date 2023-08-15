namespace WZSISTEMAS.Data.Entidades
{
    public class Funcionario
    {
        public long Id { get; set; }
        public long CargoId { get; set; }
        public string NomeCompleto { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string? RG { get; set; }
        public DateTime? DataNascimento { get; set; }

        public string Logradouro { get; set; } = null!;
        public string? LogradourNumero { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }

        public string CEP { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string Estado_UF { get; set; } = null!;

        public string? Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Telefone3 { get; set; }

        public string? Email { get; set; }

        public Cargo Cargo { get; set; } = null!;
    }
}
