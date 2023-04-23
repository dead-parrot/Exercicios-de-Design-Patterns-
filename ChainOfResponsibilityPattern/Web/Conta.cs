using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Web
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    }
}
