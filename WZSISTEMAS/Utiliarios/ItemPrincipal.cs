using System.Security.Cryptography;

namespace WZSISTEMAS.Utiliarios;

public class ItemPrincipal
{
    public long Id { get; set; }
    public string Descricao { get; set; } = default!;
    public string CodigoBarrasCodigoReferencia { get; set; } = default!;

    public decimal PesoKG { get; set; }
    public decimal Quebra { get; set; }
    public decimal CustoReal { get; set; }
    public decimal CustoRealFinal { get; set; }
    public decimal CustoRealKG { get; set; }
    public ICollection<ItemDerivado> ItensDerivados { get; protected set; }

    public ItemPrincipal(Item item)
    {
        Id = item.Id;
        Descricao = item.Descricao;
        CodigoBarrasCodigoReferencia = item.CodigoBarrasCodigoReferencia();

        ItensDerivados = item.ItensDerivados.Select(itemDerivado => new ItemDerivado
            {
                Id = itemDerivado.Id,
                Descricao = itemDerivado.Descricao,
                PesoKG = 0,
                CustoRealKG = 0,
                MargemLucro = itemDerivado.MargemLucro ?? 0,
                PrecoFinalKG = 0
            })
            .ToList();
    }

    public virtual void CalcularCustoRealKG()
    {
        CustoRealKG = CustoRealFinal / PesoKG;
    }

    public virtual void CalcularCustoRealFinal()
    {
        var porcentagem = PesoKG.CalcularPorcentagem(Quebra);
        CustoRealFinal = CustoReal.AplicarPorcentagem(porcentagem);
    }

    public virtual void RepassarCustoRealKGParaItensDerivados()
    {
        foreach (var itensDerivado in ItensDerivados)
        {

        }
    }
}