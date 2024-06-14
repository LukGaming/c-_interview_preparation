//Questão 1:

using System.Diagnostics;

sbyte smallProducts = 100;

byte mediumProducts = 200;

short largeProducts = 300;

ushort extraLargeProducts = 400;

int totalProducts = smallProducts + mediumProducts + largeProducts + extraLargeProducts;

Console.WriteLine("Total de produtos: " + totalProducts);

Debug.Assert(totalProducts == 1000);

//Questão 2:

float pi = 3.14f;

Console.WriteLine("Digite o raio do círculo: " + pi);

float raio = float.Parse("100");

double areaDoCirculo = pi * (raio * raio);

Console.WriteLine("Área do circulo " + areaDoCirculo);

Debug.Assert(areaDoCirculo == 31400.001953125);

//Questão 3

double precoDoProduto = 120;

double imposto = 27.5;

double precoDoProdutoComImpostoCobrado = (precoDoProduto * imposto) / 100;

Debug.Assert(precoDoProdutoComImpostoCobrado == 33);

//Questão 4

String stringValue = "Olá pessoal, espero que estejam bem";

int contadoDeVogais = 0;

foreach (char c in stringValue)
{
    if ("aeiouAEIOU".IndexOf((c)) >= 0)
    {
        contadoDeVogais++;
    }
}

Debug.Assert(contadoDeVogais == 13);

//Questão 5

int numero = 325;

bool numeroPar = numero % 2 == 0;

Console.WriteLine("O numero é par? " + numeroPar);

Debug.Assert(numeroPar == false);

//Questão 6

String palavras = "Frase invertida";

String[] listaPalavras = palavras.Split(" ");

Array.Reverse(listaPalavras);

String palavraReversa = string.Join(" ", listaPalavras);

Console.WriteLine("Frase reversa" + palavraReversa);

Debug.Assert(palavraReversa == "invertida Frase");











