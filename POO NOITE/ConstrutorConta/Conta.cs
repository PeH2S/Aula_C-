using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        // Declaração de atributos
        private int numero;
        private string titular;
        private double saldo;
        private static int contador;

        public static int Contador{
            get{ return contador; }
        }

        // Declaração dos métodos

        public Conta()
        {
            //Construtor padrão
            contador++;
        }
        public Conta(int numero)
        {
            this.numero = numero;
            contador++;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            contador++;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            contador++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo: {saldo:c}");
        }
        public void Transferencia(double valorTransferencia, Conta outroObjeto)
        {
            saldo -= valorTransferencia;
            outroObjeto.saldo += valorTransferencia;
        }

    }
}
