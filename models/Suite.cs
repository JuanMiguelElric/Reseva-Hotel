using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.models
{
    public class Suite
    {
        public Suite(string tipo, int capacidade, double valordecimal){
            Tipo = tipo;
            Capacidade = capacidade;
            ValorDecimal = valordecimal;
        }
        public string Tipo { get; set; }
        public int Capacidade { get; set; }
        public double ValorDecimal { get; set; }

        public void Testar(){
            Console.WriteLine($"{Tipo} {Capacidade} {ValorDecimal}");
        }
    }
}