try
{
    object o = null;
    Console.WriteLine($"Texto: {o.ToString()}");
}
catch (NullReferenceException)
{
    Console.WriteLine("O objeto é nulo.");
}

