using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Service
{
    public interface Imposto
    {
        public double Calcula(Orcamento orcamento);
    }
}
