using Exercicio03;

Console.WriteLine("Opções de exercícios:");
foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
{
    Console.WriteLine($"{exercicio.GetHashCode()} - {exercicio}");
}

// Solicita a digitação do exercício
Console.WriteLine("\nDigite o número do exercício desejado: ");
string input = Console.ReadLine();

try
{
    // Converte a string digitada para int
    int exercicioSelecionado = int.Parse(input);

    // Valida se o valor digitado é uma opção válida
    if (!Enum.IsDefined(typeof(Exercicio), exercicioSelecionado))
    {
        throw new ArgumentException("Opção inválida!");
    }

    // Exibe o nome do exercício
    Console.WriteLine($"Exercício selecionado: {(Exercicio)exercicioSelecionado}");
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Valor digitado inválido. Digite um número entre 1 e 3.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
