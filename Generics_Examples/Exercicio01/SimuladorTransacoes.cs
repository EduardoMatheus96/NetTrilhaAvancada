namespace Exercicio01;

public class SimuladorTransacoes
{
    private readonly ContaBancaria _conta1;
    private readonly ContaBancaria _conta2;

    public SimuladorTransacoes()
    {
        _conta1 = new ContaBancaria(1000);
        _conta2 = new ContaBancaria(500);
    }

    public void ExecutarTransacoes()
    {
        try
        {
            // Transações válidas
            _conta1.Depositar(500);
            _conta1.Sacar(200);
            _conta1.Transferir(100, _conta2);

            Console.WriteLine("Transações válidas realizadas com sucesso!");
        }
        catch (ValorInvalidoException ex)
        {
            Console.WriteLine($"{ex.Message} Valor inválido: {ex.ValorInvalido}");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine($"{ex.Message} Saldo disponível: {ex.SaldoDisponivel}");
        }

        // Transações inválidas
        try
        {
            _conta1.Depositar(-100);
            _conta1.Sacar(1500);
            _conta1.Transferir(700, _conta2);
        }
        catch (ValorInvalidoException ex)
        {
            Console.WriteLine($"{ex.Message} Valor inválido: {ex.ValorInvalido}");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine($"{ex.Message} Saldo disponível: {ex.SaldoDisponivel}");
        }

        ExibirSaldos();
    }

    private void ExibirSaldos()
    {
        Console.WriteLine($"\nSaldo Conta 1: {_conta1.Saldo}");
        Console.WriteLine($"Saldo Conta 2: {_conta2.Saldo}");
    }
}
