using System;

namespace POO.classes;

class Processador
{
    public String Nome { get; set; }

    public double Frequencia { get; set; }

    public int Nucleos { get; set; }

    public Processador(String nome, double frequencia, int nucleos)
    {
        this.Nome = nome;
        this.Frequencia = frequencia;
        this.Nucleos = nucleos;
    }

}

class MemoriaRam
{
    public String Nome { get; set; }
    public double Frequencia { get; set; }

    public int QuantidadeGb { get; set; }

    public MemoriaRam(String nome, double frequencia, int quantidadeGb)
    {
        this.Nome = nome;
        this.Frequencia = frequencia;
        this.QuantidadeGb = quantidadeGb;
    }

}

class DiscoRigido
{
    public String Nome { get; set; }
    public double Tamanho { get; set; }

    public DiscoRigido(String nome, double tamanho)
    {
        this.Nome = nome;
        this.Tamanho = tamanho;

    }
}

class Computador
{
    public Processador Processador { get; set; }
    public MemoriaRam MemoriaRam { get; set; }

    public DiscoRigido DiscoRigido1 { get; set; }

    public Computador(
        Processador Processador,
        MemoriaRam memoriaRam,
        DiscoRigido discoRigido1
    )
    {
        this.Processador = Processador;
        this.MemoriaRam = memoriaRam;
        this.DiscoRigido1 = discoRigido1;
    }

    public override string ToString()
    {
        return "Processador: " + this.Processador.Nome + " Memória ram: " + this.MemoriaRam.Nome + "Disco: " + this.DiscoRigido1.Nome;
    }
}