using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Vendedor Vend { get; set; }
        public Comprador Comp { get; set; }
        public List<Produto> VetProd { get; set; }

        public Venda()
        {

        }
        public Venda(Vendedor vend, Comprador comp)
        {
            Vend = vend;
            Comp = comp;
            
          
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Vendedor: {Vend} \tComprador: {Comp}");    
        }
    }
}