using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ContaBancaria
    {
        public EstadoDaConta EstadoAtual { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string titular, double saldo = 0)
        {
            EstadoAtual = new SaldoPositivo();
            Titular = titular;
            Saldo = saldo;
        }   

        public void Depositar(double valor)
        {
            EstadoAtual.Depositar(this, valor);
        }

        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this, valor);
        }

    }
}
