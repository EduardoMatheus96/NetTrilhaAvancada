namespace Exercicio04;

public class ServicoFabrica
{
    public T NovaInstancia<T>() where T : IServico, new()
    {
        if (!typeof(T).IsInterface || !typeof(IServico).IsAssignableFrom(typeof(T)))
        {
            throw new ArgumentException("O tipo T deve implementar a interface IServico.");
        }
        return new T();
    }
}
