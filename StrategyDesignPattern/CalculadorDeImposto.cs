using StrategyDesignPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CalculadorDeImposto
    {
        public CalculadorDeImposto() { }
        public void CalcularImposto(Orcamento orcamento, Imposto imposto)
        {
            double valorDoImposto = imposto.Calcula(orcamento);
            Console.WriteLine($"O valor do imposto é R${valorDoImposto}");
        }
    }
}
