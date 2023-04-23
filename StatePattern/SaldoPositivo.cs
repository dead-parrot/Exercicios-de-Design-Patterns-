using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SaldoPositivo : EstadoDaConta
    {
        public void Depositar(ContaBancaria contaBancaria, double valor)
        {
            contaBancaria.Saldo += (0.98 * valor);
        }

        public void Sacar(ContaBancaria contaBancaria, double valor)
        {
            contaBancaria.Saldo -= valor;
            if (contaBancaria.Saldo < 0)
                contaBancaria.EstadoAtual = new SaldoNegativo();
        }
    }
}
