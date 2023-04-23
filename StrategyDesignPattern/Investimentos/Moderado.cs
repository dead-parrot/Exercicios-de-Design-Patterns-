using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Investimentos
{
    public class Moderado : Investimento
    {
        public double Investir(double valorNaConta)
        {
            double porcentagemSemImposto = 0.75;

            bool ehMaiorque50 = new Random().Next(101) > 50;

            if (ehMaiorque50)
                return valorNaConta * 0.007 * porcentagemSemImposto;

            return valorNaConta * 0.025 * porcentagemSemImposto;
            
        }
    }
}
