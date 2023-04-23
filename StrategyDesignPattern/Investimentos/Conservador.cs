using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Investimentos
{
    public class Conservador : Investimento
    {
        public double Investir(double valorNaConta)
        {
            double PorcentagemSemImposto = 0.75;
            return valorNaConta * 0.008 * PorcentagemSemImposto;
        }
    }
}
