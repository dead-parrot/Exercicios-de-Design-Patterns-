using ChainOfResponsibilityPattern.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface Filtro
    {
        public IList<Conta> Filtra(IList<Conta> contas);
    }
}
