using ChainOfResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Descontos
{
    public class DescontoCompraMais500 : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double calcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return orcamento.Valor * 0.07;

            return Proximo.calcularDesconto(orcamento);

        }

        public DescontoCompraMais500(IDesconto proximo)
        {
            Proximo = proximo;
        }
    }
}
