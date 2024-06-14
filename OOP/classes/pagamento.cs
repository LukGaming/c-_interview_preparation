using System;

namespace POO.classes;

interface IPagamento
{
    public void ProcessarPagamento();

    public void EstornarPagamento();
}

class CartaoDeCredito : IPagamento
{

    public void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento em Cartão de crédito");
    }

    public void EstornarPagamento()
    {
        Console.WriteLine("Estornando pagamento em crédito");
    }
}

class Boleto : IPagamento
{

    public void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento em Boleto");
    }

    public void EstornarPagamento()
    {
        Console.WriteLine("Estornando pagamento em Boleto");
    }
}