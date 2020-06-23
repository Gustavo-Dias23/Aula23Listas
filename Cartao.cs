using System;
namespace Aula23Listas
{
    public class Cartao
    {
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public DateTime DataDeVencimento { get; set; }

        public Cartao(){

        }
        public Cartao(string _titular, int _numero, string _bandeira, DateTime _datadevencimento){
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.DataDeVencimento = _datadevencimento;
        }
    }
}