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
            VetProd = new List<Produto>(); // Inicializando a lista
        }
        public Venda(Vendedor vend, Comprador comp)
        {
            Vend = vend;
            Comp = comp;
            VetProd = new List<Produto>(); 

        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Vendedor: {Vend} \tComprador: {Comp}");
            Console.WriteLine("Produtos na venda:");
            foreach (var produto in VetProd)
            {
                produto.MostrarAtributos();
            }
        }
        public void AdicionarProduto(Produto produto)
        {
    
            VetProd.Add(Produto);           
        }
    }
}