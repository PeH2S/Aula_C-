using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        
        private string nome;
        private double preco;
        private int qtd;

        //Métodos set e get
        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome.ToUpper();
            }
        }
        public double Preco{
            set{
                this.preco = value;
            }
            get{
                return this.preco;
            }
        }
        public int Qtd{
            set{
                if (value > 0)
                    this.qtd = value;
                else
                    System.Console.WriteLine("Quantidade inválida");
            }
            get{
                return this.qtd;
            }
        }
        public void Mostrar()
        {
            System.Console.WriteLine("Nome: " + nome + "\tPreço: " + preco + "\tQuantidade: " + qtd);
        }
        public void AdicionarProduto(int qtd)
        {
            qtd += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            qtd -= qtd;
        }
        public double ValorTotalEstoque()
        {
            return preco * qtd;
        }
    }
}