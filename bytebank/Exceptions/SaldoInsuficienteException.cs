using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { } 

        public SaldoInsuficienteException(string message) : base(message) { }

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            :this ($"Tentativa de saque no valor de R${valorSaque},00 com saldo atual de R${saldo},00 ")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }   
    }
}
