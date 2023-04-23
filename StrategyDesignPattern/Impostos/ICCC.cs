using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Service
{
    public class ICCC : Imposto
    {
        public ICCC() { }
        public double Calcula(Orcamento orcamento)
        {
            double valorDoOrcamento = orcamento.Valor;

            if (valorDoOrcamento < 0)
                throw new Exception("Valor negativo de orçamento");

            if (valorDoOrcamento < 1000)
                return valorDoOrcamento * 0.05;
            else if (valorDoOrcamento >= 1000 && valorDoOrcamento <= 3000)
                return valorDoOrcamento * 0.07;
            else
                return valorDoOrcamento * 0.08 + 30;
        }
    }
}


