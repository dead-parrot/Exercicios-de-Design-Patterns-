using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Investimentos
{
    public interface Investimento
    {
        public double Investir(double valorNaConta);
    }
}
