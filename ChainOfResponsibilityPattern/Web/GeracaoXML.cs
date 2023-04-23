using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Web
{
    public class GeracaoXML : IGeracao
    {
        public IGeracao Proximo { get; set; }
        public string GerarRequisicaoTratada(Conta conta, Requisicao requisicao)
        {
            if(requisicao.Formato == Formato.XML)
                return $"<Titular>\n\t<{conta.Titular}>\n" +
                       $"<Saldo>\n\t<{conta.Saldo}>\n";

            return Proximo.GerarRequisicaoTratada(conta, requisicao);
        }

        public GeracaoXML(IGeracao proximo)
        {
            Proximo = proximo;
        }
    }
}
