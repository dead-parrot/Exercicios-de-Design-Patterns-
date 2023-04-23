using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Investimentos
{
    public class ContaBancaria
    {
        public double Valor { get; set;}

        public double Deposita(double valorNaConta, Investimento investimento)
        {
            Valor += investimento.Investir(valorNaConta);
            return Valor;
        }
        
    }
}
