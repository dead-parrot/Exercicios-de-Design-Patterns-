// See https://aka.ms/new-console-template for more information


using ChainOfResponsibilityPattern.Descontos;
using ChainOfResponsibilityPattern.Web;

Conta conta = new Conta("Rogério Marinho", 1500);
Requisicao requisicao = new Requisicao(Formato.XML);

IGeracao porcento = new GeracaoPorcento(proximo: null);
IGeracao csv = new GeracaoCSV(porcento);
IGeracao xml = new GeracaoXML(csv);

Console.WriteLine(xml.GerarRequisicaoTratada(conta, requisicao));

IDesconto d1 = new SemDesconto();
IDesconto d2 = new DescontoVendaCasada(d1);
IDesconto d3 = new DescontoCompraMais500(d2);
IDesconto d4 = new Desconto5Itens(d3);

Orcamento orcamento = new Orcamento(500);
orcamento.AdicionarItem(new Item("Lápis", 100));
orcamento.AdicionarItem(new Item("Caneta", 250));
orcamento.AdicionarItem(new Item("Borracha", 250));
orcamento.AdicionarItem(new Item("Caderno", 250));
orcamento.AdicionarItem(new Item("LiquidPaper", 250));
orcamento.AdicionarItem(new Item("Canetinha", 250));

Console.WriteLine($"O desconto foi de R${d4.calcularDesconto(orcamento)}");
    