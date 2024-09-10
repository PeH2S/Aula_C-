﻿using Classe;

// Instanciar objetos
Conta c1; // Declaração de uma variável
c1 = new Conta(); // Instância de obejto --> new para frente
c1.numero = 1;
c1.titular = "Fatec";
c1.saldo = 100;
Console.WriteLine("Número: " + c1.numero + "\tTitular: " + c1.titular + "\tSaldo: " + c1.saldo);

Conta c2 = new Conta();
c2.numero = 2;
c2.titular = "Empresa Jr";
c2.saldo = 200;

Console.WriteLine("Número: " + c2.numero + "\tTitular: " + c2.titular + "\tSaldo: " + c2.saldo);

c2.Transferencia(50, c1);

Console.WriteLine("Número: " + c2.numero + "\tTitular: " + c2.titular + "\tSaldo: " + c2.saldo);
Console.WriteLine("Número: " + c1.numero + "\tTitular: " + c1.titular + "\tSaldo: " + c1.saldo);

/*Conta c3 = new Conta();
System.Console.Write("Cadastre o número da conta: ");
c3.numero = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Cadastre o titular da conta: ");
c3.titular = Console.ReadLine();
System.Console.Write("Cadastre o saldo da conta: ");
c3.saldo = Convert.ToDouble(Console.ReadLine());
*/
