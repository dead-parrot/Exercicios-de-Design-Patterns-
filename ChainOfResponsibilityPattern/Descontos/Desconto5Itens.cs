using ChainOfResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Descontos
{
    public class Desconto5Itens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double calcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;

            return Proximo.calcularDesconto(orcamento);
        }

        public Desconto5Itens(IDesconto proximo)
        {
            Proximo = proximo;
        }

    }
}
