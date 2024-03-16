using Exercicio04;

var fabrica = new ServicoFabrica();

var servico1 = fabrica.NovaInstancia<ServicoExemplo1>();
servico1.Executar();

var servico2 = fabrica.NovaInstancia<ServicoExemplo2>();
servico2.Executar();
