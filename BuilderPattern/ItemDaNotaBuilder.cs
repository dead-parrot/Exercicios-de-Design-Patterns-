using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ItemDaNotaBuilder
    {
        private string Nome { get; set; }
        private double Valor { get; set; }

        
        public ItemDaNotaBuilder()
        {

        }

        public ItemDaNota Constroi(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
            return new ItemDaNota(nome, Valor);
        }

        public ItemDaNotaBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

    }
}
