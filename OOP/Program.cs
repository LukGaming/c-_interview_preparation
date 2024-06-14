using System.Diagnostics;
using OOP.classes;
using POO.classes;

var pessoa = new Pessoa
        (
             "Paulo",
             26,
             "Rua Joaquim delfino"
        );

Console.WriteLine(pessoa.ToString());

Console.WriteLine(pessoa.idadeEmDias());


var veiculo = new Carro("Sandero", "Renault", "2014");


var moto = new Moto("Mt-07", "Yamaha", "2023");

Console.WriteLine(veiculo.ExibirInformacoes());

Console.WriteLine(moto.ExibirInformacoes());

//Desafio 3 

FormaGeometrica circulo = new Circulo(5);

FormaGeometrica quadrado = new Quadrado(4);

FormaGeometrica retangulo = new Retangulo(5, 8);

Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");
Console.WriteLine($"Área do Quadrado: {quadrado.CalcularArea()}");
Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");

//Desafio 4

IPagamento pagamentoEmCredito = new CartaoDeCredito();

pagamentoEmCredito.ProcessarPagamento();

pagamentoEmCredito.EstornarPagamento();

IPagamento pagamentoEmBoleto = new Boleto();

pagamentoEmBoleto.ProcessarPagamento();

pagamentoEmBoleto.EstornarPagamento();

//Desafio 5

ContaBancaria conta = new ContaBancaria(200, "Número da conta");

conta.Depositar(300);

Debug.Assert(conta.ConsultarSaldo() == 500);

conta.Sacar(500);

Debug.Assert(conta.ConsultarSaldo() == 0);

//Desafio 6

Processador processador = new Processador("AMD Ryzen 7 3700x", 4.5, 16);

MemoriaRam memoriaRam = new MemoriaRam("Corsair", 3200, 8);

DiscoRigido discoRigido = new DiscoRigido("SSD Kingston", 512);

Computador computador = new Computador(processador, memoriaRam, discoRigido);

Console.WriteLine("Informações do computador: " + computador.ToString());

//Desafio 7

Cliente cliente = new("Paulo", "Rua joaquim delfino");

Pedido pedido = new("Pedido 1", DateTime.Now, cliente);

//Desafio 8 



