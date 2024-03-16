using Exercicio05;

// Triângulo com pontos de tipo int
    var trianguloInt = new Triangulo<int>(
        new Ponto<int>(1, 2, 3),
        new Ponto<int>(4, 5, 6),
        new Ponto<int>(7, 8, 9)
    );

    Console.WriteLine(trianguloInt);

    // Triângulo com pontos de tipo double
    var trianguloDouble = new Triangulo<double>(
        new Ponto<double>(1.5, 2.5, 3.5),
        new Ponto<double>(4.5, 5.5, 6.5),
        new Ponto<double>(7.5, 8.5, 9.5)
    );

    Console.WriteLine(trianguloDouble);

    // Triângulo com pontos de tipo string
    var trianguloString = new Triangulo<string>(
        new Ponto<string>("A", "B", "C"),
        new Ponto<string>("D", "E", "F"),
        new Ponto<string>("G", "H", "I")
    );

    Console.WriteLine(trianguloString);
