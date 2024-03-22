static async Task DoWorkAsync(string taskName)
{
    for (int i = 0; i < 10; i++)
    {
        await Task.Delay(1000);
        Console.WriteLine($"{taskName}: {i * 10}%");
    }
    Console.WriteLine($"{taskName}: Finalizada!");
}

var task1 = DoWorkAsync("Tarefa 1");
var task2 = DoWorkAsync("Tarefa 2");

await Task.WhenAll(task1, task2);

Console.WriteLine("Todas as tarefas finalizadas!");
