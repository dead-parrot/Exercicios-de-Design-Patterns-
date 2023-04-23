// See https://aka.ms/new-console-template for more information

using StrategyDesignPattern;
using StrategyDesignPattern.Service;

Orcamento orcamento = new Orcamento(5000);

Imposto iccc = new ICCC();

CalculadorDeImposto c = new CalculadorDeImposto();

c.CalcularImposto(orcamento, iccc);

