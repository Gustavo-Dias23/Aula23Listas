using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Produtos disponíveis:");
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "PS5", 7999.99f));
            produtos.Add(new Produto(2, "XBOX SERIES X", 7999.99f));
            produtos.Add(new Produto(3, "NINTENDO SWITCH", 4499.99f));
            produtos.Add(new Produto(4, "WII", 999.99f));

            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R${p.Preco}");
            }
            System.Console.WriteLine("\n Cartões disponíveis:");
            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add(new Cartao("Roberto", 31313141, "Visa", DateTime.Parse("28/08/2022") ));
            cartoes.Add(new Cartao("Gustavo", 74156164, "MasterCard", DateTime.Parse("23/03/2022") ));
            cartoes.Add(new Cartao("Luana", 75798223, "NuBank", DateTime.Parse("18/09/2021") ));

            foreach(Cartao c in cartoes){
                Console.WriteLine($"{c.Titular} - {c.Numero} - {c.Bandeira} - {c.DataDeVencimento.ToShortDateString()}");
            }
        }
    }
}
