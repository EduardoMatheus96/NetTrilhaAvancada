namespace Exercicio03;

public class Worker
{
    public void Work()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i * 10}%");
        }
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Finalizada!");
    }
}
