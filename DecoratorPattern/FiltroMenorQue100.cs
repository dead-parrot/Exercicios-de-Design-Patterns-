using ChainOfResponsibilityPattern.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FiltroMenorQue100 : Filtro
    {
        public Filtro? OutroFiltro { get; set; }
        public FiltroMenorQue100(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public FiltroMenorQue100()
        {
            this.OutroFiltro = null;
        }
        public IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtradas = (IList<Conta>)contas.Select(conta => conta.Saldo > 100);

            if (OutroFiltro == null)
                return filtradas;

            var filtradasPeloOutroFiltro = OutroFiltro.Filtra(contas);

            return (IList<Conta>)filtradas.Concat(filtradasPeloOutroFiltro).Distinct();

        }

    }
}
