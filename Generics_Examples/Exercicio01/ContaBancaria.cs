namespace Exercicio01;
public class ContaBancaria
{
    private double _saldo;

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public double Saldo
    {
        get => _saldo;
        private set
        {
            if (value < 0)
            {
                throw new ValorInvalidoException("Saldo não pode ser negativo.", value);
            }
            _saldo = value;
        }
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor a sacar deve ser positivo.", valor);
        }

        if (valor > Saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para saque.", Saldo);

        }

        Saldo -= valor;
    }
    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor a depositar deve ser positivo.", valor);
        }

        Saldo += valor;
    }

    public void Transferir(double valor, ContaBancaria contaDestino)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor a transferir deve ser positivo.", valor);
        }

        if (valor > Saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para transferência.", Saldo);
        }

        Saldo -= valor;
        contaDestino.Saldo += valor;
    }
}
