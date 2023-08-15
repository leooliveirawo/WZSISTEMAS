using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZSISTEMAS.Data.Entidades
{
    public class Cargo
    {
        public long Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }

        public Cargo()
        {
            Funcionarios = new HashSet<Funcionario>();
        }
    }
}
