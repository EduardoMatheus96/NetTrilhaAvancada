using Exercicio02;
using static Exercicio02.Itens;

List<ItemMercado> itens = GetItens();

// Call all LINQ queries from LinqConsultas

var itensHigieneOrdenadosPorPreco = LinqConsultas.ItensHigieneOrdenadosPorPrecoDecrescente(itens);
var itensComPrecoMaiorQueCinco = LinqConsultas.ItensComPrecoMaiorQueCincoOrdenadosPorPreco(itens);
var itensComidaOuBebida = LinqConsultas.ItensComidaOuBebidaOrdenadosPorNome(itens);
var quantidadeItensPorTipo = LinqConsultas.QuantidadeItensPorTipo(itens);
var precosPorTipo = LinqConsultas.PrecosPorTipo(itens);

// Print results or perform further actions

Console.WriteLine("Itens de higiene ordenados por preço decrescente:");
foreach (var item in itensHigieneOrdenadosPorPreco)
{
    Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
}

Console.WriteLine();

Console.WriteLine("Itens com preço maior ou igual a R$ 5,00 ordenados por preço crescente:");
foreach (var item in itensComPrecoMaiorQueCinco)
{
    Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
}

Console.WriteLine();

Console.WriteLine("Itens do tipo Comida ou Bebida ordenados por nome:");
foreach (var item in itensComidaOuBebida)
{
    Console.WriteLine($"{item.Nome} - {item.Tipo}");
}

Console.WriteLine();

Console.WriteLine("Quantidade de itens por tipo:");
foreach (var item in quantidadeItensPorTipo)
{
    Console.WriteLine($"{item.Tipo} - {item.Quantidade}");
}

Console.WriteLine();

Console.WriteLine("Preços por tipo:");
foreach (var item in precosPorTipo)
{
    Console.WriteLine($"{item.Tipo}:");
    Console.WriteLine($"\tPreço máximo: R$ {item.PrecoMaximo}");
    Console.WriteLine($"\tPreço mínimo: R$ {item.PrecoMinimo}");
    Console.WriteLine($"\tMédia de preço: R$ {item.MediaPreco:F2}"); // Format currency with two decimal places
}
