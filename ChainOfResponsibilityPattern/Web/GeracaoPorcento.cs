using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Web
{
    public class GeracaoPorcento : IGeracao
    {
        public IGeracao? Proximo { get; set; }
        public string GerarRequisicaoTratada(Conta conta, Requisicao requisicao)
        {
            return $"Titular:{conta.Titular}%Saldo:{conta.Saldo}";
        }

        public GeracaoPorcento(IGeracao proximo)
        {
            Proximo = proximo;
        }
    }
}
