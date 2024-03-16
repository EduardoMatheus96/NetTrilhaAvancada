namespace Exercicio01;

public class ValorInvalidoException : Exception
{
    public double ValorInvalido { get; }

    public ValorInvalidoException(string message, double valorInvalido) : base(message)
    {
        ValorInvalido = valorInvalido;
    }
}
