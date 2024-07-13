using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exGeral
{
    internal class Conta
    {
        public int Numero;
        public string Nome;
        public double Valor;

        public Conta(int numero, string nome, double valor)
        {
            Numero = numero;
            Nome = nome;
            Valor = valor;
        }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Valor = 0.0;
        }

        public void Deposito(double deposito)
        {
            Valor += deposito;
        }

        public void Saque(double saque)
        {
            Valor -= (saque + 5.00);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: " + Valor.ToString("F2", CultureInfo.InvariantCulture) ;  
        }



    }

    
}
