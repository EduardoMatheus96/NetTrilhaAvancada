using aula02;

Lampada lamp = new Lampada(true);

lamp.Imprimir();
lamp.Desligar();
lamp.Imprimir();


Data data1 = new Data(12, 3, 2024);
data1.Imprimir(Data.FORMATO_24H);

Data data2 = new Data(12, 3, 2024, 15, 14, 7);
data2.Imprimir(Data.FORMATO_12H);
