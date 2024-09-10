using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        

        public Vendedor()
        {
            
        }
        public Vendedor(double comissao)
        {
            Comissao = 2 / 100;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Comissão: {Comissao:c}");
        }
    }
}