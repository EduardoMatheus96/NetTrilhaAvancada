namespace Exercicio02;

public class LinqConsultas
{
    public static List<ItemMercado> ItensHigieneOrdenadosPorPrecoDecrescente(List<ItemMercado> itens)
    {
        return itens
            .Where(item => item.Tipo == Tipo.Higiene)
            .OrderByDescending(item => item.Preco)
            .ToList();
    }

    public static List<ItemMercado> ItensComPrecoMaiorQueCincoOrdenadosPorPreco(List<ItemMercado> itens)
    {
        return itens
            .Where(item => item.Preco >= 5.00)
            .OrderBy(item => item.Preco)
            .ToList();
    }

    public static List<ItemMercado> ItensComidaOuBebidaOrdenadosPorNome(List<ItemMercado> itens)
    {
        return itens
            .Where(item => item.Tipo == Tipo.Comida || item.Tipo == Tipo.Bebida)
            .OrderBy(item => item.Nome)
            .ToList();
    }

    public static List<TipoQuantidade> QuantidadeItensPorTipo(List<ItemMercado> itens)
    {
        return itens
            .GroupBy(item => item.Tipo)
            .Select(grupo => new TipoQuantidade
            {
                Tipo = grupo.Key,
                Quantidade = grupo.Count()
            })
            .ToList();
    }

    public static List<TipoPreco> PrecosPorTipo(List<ItemMercado> itens)
    {
        return itens
            .GroupBy(item => item.Tipo)
            .Select(grupo => new TipoPreco
            {
                Tipo = grupo.Key,
                PrecoMaximo = grupo.Max(item => item.Preco),
                PrecoMinimo = grupo.Min(item => item.Preco),
                MediaPreco = grupo.Average(item => item.Preco)
            })
            .ToList();
    }
}
