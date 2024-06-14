using System;

namespace POO.classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }

    public class Pedido
    {
        public Pedido(string numeroPedido,
        DateTime horarioPedido,
        Cliente cliente
        )
        {
            this.NumeroPedido = numeroPedido;
            this.HorarioPedido = horarioPedido;
            this.Cliente = cliente;
        }

        public string NumeroPedido { get; set; }
        public DateTime HorarioPedido { get; set; }

        public Cliente Cliente { get; set; }
    }
}