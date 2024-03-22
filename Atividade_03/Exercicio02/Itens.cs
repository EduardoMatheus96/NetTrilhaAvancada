namespace Exercicio02;

public static class Itens
{
    public static List<ItemMercado> GetItens()
    {
        return new List<ItemMercado>()
        {
            new("Arroz", Tipo.Comida, 3.90),
            new("Azeite", Tipo.Comida, 2.50),
            new("Macarrão", Tipo.Comida, 3.90),
            new("Cerveja", Tipo.Bebida, 22.90),
            new("Refrigerante", Tipo.Bebida, 5.50),
            new("Shampoo", Tipo.Higiene, 7.00),
            new("Sabonete", Tipo.Higiene, 2.40),
            new("Cotonete", Tipo.Higiene, 5.70),
            new("Sabão em pó", Tipo.Limpeza, 8.20),
            new("Detergente", Tipo.Limpeza, 2.60),
            new("Amaciante", Tipo.Limpeza, 6.40),
        };
    }
}
