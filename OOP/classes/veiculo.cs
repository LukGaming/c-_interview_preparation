using System;

namespace POO.classes;

abstract class Veiculo
{
    public abstract string Modelo { get; set; }
    public abstract string Marca { get; set; }

    public abstract string Ano { get; set; }

    public virtual string ExibirInformacoes()
    {
        return "Modelo: " + Modelo + " Marca: " + Marca + " Ano: " + Ano;
    }
}

class Carro : Veiculo
{
    public override string Modelo { get; set; }
    public override string Marca { get; set; }

    public override string Ano { get; set; }

    public Carro(string modelo, string marca, string ano)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
    }

    public override string ExibirInformacoes()
    {
        return "Modelo: " + Modelo + " Marca: " + Marca + " Ano: " + Ano;
    }
}

class Moto : Veiculo
{
    public override string Modelo { get; set; }
    public override string Marca { get; set; }

    public override string Ano { get; set; }


    public Moto(string modelo, string marca, string ano)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
    }

    public override string ExibirInformacoes()
    {
        return "Modelo: " + Modelo + " Marca: " + Marca + " Ano: " + Ano;
    }

}