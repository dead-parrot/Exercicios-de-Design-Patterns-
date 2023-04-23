using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Investir(double valorNaConta)
        {
            double porcentagemSemImposto = 0.75;

            int probabilidade = new Random().Next(100);

            double lucro;
            if (probabilidade < 20)
                lucro = 0.05;
            else if (probabilidade >= 20 && probabilidade < 50)
                lucro = 0.03;
            else
                lucro = 0.006;

            return lucro * porcentagemSemImposto;

        }
    }
}
