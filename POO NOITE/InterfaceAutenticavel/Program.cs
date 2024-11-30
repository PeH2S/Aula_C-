using InterfaceAutenticavel;

//IAutenticavel ia = new IAutenticavel(); erro de compilação

Cliente c = new Cliente();
c.Senha = 123;

IAutenticavel ia = c;

System.Console.WriteLine(ia.Autentica(123));

Gerente g = new Gerente();
g.Senha = 100;

ia = g;

System.Console.WriteLine(ia.Autentica(100));

Diretor d = new Diretor();
d.Senha = 200;

ia = d;

System.Console.WriteLine(ia.Autentica(200));