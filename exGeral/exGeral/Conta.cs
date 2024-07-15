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
        private int _numero;
        private string _nome;
        private double _valor;

        public int Numero
        {  get { return _numero; }        
        }

        public string Nome
        {
            get { return _nome; }
            set { value = _nome; }
        }

        public double Valor
        {
            get { return _valor; }
        }

        public Conta()
        { 
        }
        
        public Conta(int numero, string nome, double valor)
        {
            _numero = numero;
            Nome = nome;
            _valor = valor;
        }

        public Conta(int numero, string nome)
        {
            _numero = numero;
            Nome = nome;
        }

        public void Deposito(double deposito)
        {
            _valor += deposito;
        }

        public void Saque(double saque)
        {
            _valor -= (saque + 5.00);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: " + Valor.ToString("F2", CultureInfo.InvariantCulture) ;  
        }



    }

    
}
