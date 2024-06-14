using System;

namespace POO.classes;


abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}

class Circulo : FormaGeometrica
{
    public double Raio { get; set; }
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}

class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}

class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}