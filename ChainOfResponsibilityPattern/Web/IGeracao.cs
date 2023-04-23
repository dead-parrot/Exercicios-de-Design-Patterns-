using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Web
{
    public interface IGeracao
    {
        public IGeracao Proximo { get; set; }
        public string GerarRequisicaoTratada(Conta conta, Requisicao requisicao);
    }
}
