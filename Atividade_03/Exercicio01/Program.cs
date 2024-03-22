List<double> numeros = new List<double>() { 3, 7, 2, 4, 6 };

List<double> resultados = numeros.ConvertAll(numero => numero / 2);

resultados.ForEach(resultado => Console.WriteLine(resultado));
