using ConstrutorConta;

Conta c1 = new Conta(10);
c1.MostrarAtributos();
Conta c2 = new Conta(20);
c2.MostrarAtributos();
System.Console.WriteLine("Quantidade de instâncias: "+Conta.Contador);
