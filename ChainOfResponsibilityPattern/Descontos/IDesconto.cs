using ChainOfResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Descontos
{
    public interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double calcularDesconto(Orcamento orcamento);
    }
}
