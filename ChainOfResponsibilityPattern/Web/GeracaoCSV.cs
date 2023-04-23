using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Web
{
    public class GeracaoCSV : IGeracao
    {
        public IGeracao Proximo { get; set; }
        public string GerarRequisicaoTratada(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
                return $"Titular:{conta.Titular};Saldo:{conta.Saldo}";

            return Proximo.GerarRequisicaoTratada(conta, requisicao);
        }

        public GeracaoCSV(IGeracao proximo)
        {
            Proximo = proximo;
        }
    }
}
