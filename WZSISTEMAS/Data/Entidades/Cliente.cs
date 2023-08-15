using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZSISTEMAS.Data.Entidades
{
    public class Cliente
    {
        public enum Tipos
        {
            PessoaFisica,
            PessoaJuridica
        }

        public long Id { get; set; }
        public Tipos Tipo { get; set; }
        public string NomeCompleto_RazaoSocial { get; set; } = null!;
        public string CPF_CNPJ { get; set; } = null!;
        public string? RG_InscricaoEstadual { get; set; }
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
    }
}
