using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataProduto
{
    public class Disco : Produto
    {
        public string Artista { get; set; }   
        public string Gravadora { get; set; }

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine($"Autor: {Autor} \tISBN: {Isbn}");
        }
        public override void AtualizarPreco(double preco)
        {
            this.Preco = preco;
        }
    }
}