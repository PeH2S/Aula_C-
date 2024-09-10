
using AgregacaoVenda;

Produto p1 = new Produto(1, "Macarrão", 10);
Produto p2 = new Produto(2, "Molho de tomate", 5);
Produto p3 = new Produto(3, "Palmito", 15);


Comprador comp1 = new Comprador(10.000);
Comprador comp2 = new Comprador(20.000);
Comprador comp3 = new Comprador(5.000);



Venda v1 = new Venda();

v1.VetProd = new List<Produto>();

v1.VetProd.Add(p1);
v1.VetProd.Add(p2);
v1.VetProd.Add(p3);
v1.VetProd.Add(comp1);
v1.VetProd.Add(comp2);
v1.VetProd.Add(comp3);
