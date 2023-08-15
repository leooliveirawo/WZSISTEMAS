using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoCargos : IServicoCargosConsultas
    {
        Task CriarAsync(Cargo cadastro);
        Task EditarAsync(Cargo cadastro);
        Task ExcluirAsync(long id);
    }
}
