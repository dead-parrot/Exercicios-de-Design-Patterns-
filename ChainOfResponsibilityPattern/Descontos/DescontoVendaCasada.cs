using ChainOfResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Descontos
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double calcularDesconto(Orcamento orcamento)
        {
            bool possuiLapis = orcamento.Itens.Exists(x => x.Name == "Lápis");
            bool possuiCaneta = orcamento.Itens.Exists(x => x.Name == "Caneta");

            if (possuiLapis && possuiCaneta)
                return orcamento.Valor * 0.05;

            return Proximo.calcularDesconto(orcamento);
        }

        public DescontoVendaCasada(IDesconto proximo)
        {
            Proximo = proximo;
        }
    }
}
