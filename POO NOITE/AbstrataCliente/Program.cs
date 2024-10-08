// Método Main()

using AbstrataCliente;
// gera erro por não poder instanciar
// Cliente c = new Cliente(1, "Ana");

ClienteFisico cf = new ClienteFisico(2, "Bia", 22, 222);
cf.MostrarAtributos();

Teste t = new Teste();
t.AvaliarIdade(cf);

ClienteJuridico cj = new ClienteJuridico(3, "Carlos", 47, 3456);
cj.MostrarAtributos();
t.AvaliarIdade(cj);
