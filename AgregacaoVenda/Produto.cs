using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } 
        public double Preco { get; set; }
        
        //Criar 3 construtores
        public Produto()
        {

        }
        public Produto(int codigo, string nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
        public Produto(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = 0.0; // Valor padrão para o preço
        }
        //Criar Metodo MostrarAtributos()
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tPreço: {Preco:c}");
        }
    }
}