﻿namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoEntidades<TEntidade> where TEntidade : Entidade
{
   void Criar(TEntidade entidade);
   void CriarVarios(IEnumerable<TEntidade> entidades);
   void Editar(TEntidade entidade);
   void EditarVarios(IEnumerable<TEntidade> entidades);
   void ExcluirPeloId(long id);

    TEntidade? ObterPorId(
        long id,
        bool usarRastreamento = false);

    IEnumerable<TEntidade> ObterLista();
    IEnumerable<ItemLista<long>> ObterListaItens();
   void DescartarAlteracoes();
   void SalvarAlteracoes();

    bool Contem();
}