using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Service
{
    public class ICMS : Imposto
    {
        public ICMS() { }
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50;
        }
    }
}
