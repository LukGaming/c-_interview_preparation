using System;

namespace OOP.classes;
class Pessoa
{
    public String nome;
    public int idade;
    public String endereco;

    public Pessoa(String nome, int idade, string endereco)
    {
        this.nome = nome;
        this.idade = idade;
        this.endereco = endereco;
    }

    public override String ToString()
    {
        return "nome: " + nome + " idade: " + idade + " endereço: " + endereco;
    }

    public String idadeEmDias()
    {
        return "Idade em dias " + (idade * 365).ToString();
    }


}
