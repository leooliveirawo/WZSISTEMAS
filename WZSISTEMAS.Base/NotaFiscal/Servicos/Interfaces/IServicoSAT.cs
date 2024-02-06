using WZSISTEMAS.Base.NotaFiscal.Valores;
using WZSISTEMAS.Base.NotaFiscal.Valores.SAT;

namespace WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;

public interface IServicoSAT
{
    DadosSAT? ImportarDadosSAT();

    DadosSAT? CarregarDadosLocalmente();
   void SalvarDadosLocalmente(DadosSAT dadosSAT);

   void Criar(DadosSAT dadosSAT, CFe cFe);
   void Cancelar(CFe cFe);
   void Cancelar(string nCFe);
}
