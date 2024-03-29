﻿namespace WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

public interface IServicoCartao
{
    event TransacaoCartaoEventHandler? Iniciou;
    event TransacaoCartaoEventHandler? Comunicou;
    event TransacaoCartaoEventHandler? Cancelou;
    event TransacaoCartaoEventHandler? Finalizou;

   void CancelarTransacao();
   void IniciarTransacao(decimal valorMonetario);
}
