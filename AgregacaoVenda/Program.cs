
using AgregacaoVenda;

Produto p1 = new Produto(1, "Macarrão", 10);
Produto p2 = new Produto(2, "Molho de tomate", 5);
Produto p3 = new Produto(3, "Palmito", 15);

// Criando compradores
Comprador comp1 = new Comprador(10000);
Comprador comp2 = new Comprador(20000);
Comprador comp3 = new Comprador(5000);

// Criando uma venda
Venda v1 = new Venda();

// Adicionando produtos à venda
v1.AdicionarProduto(p1);
v1.AdicionarProduto(p2);
v1.AdicionarProduto(p3);

// Exibindo atributos da venda
v1.MostrarAtributos();
