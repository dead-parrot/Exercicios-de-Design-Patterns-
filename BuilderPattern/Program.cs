// See https://aka.ms/new-console-template for more information
using BuilderPattern;


NotaFiscalBuilder builder = new NotaFiscalBuilder();
builder.AdicionaAcao(new EmailSender());
builder.AdicionaAcao(new NotaFiscalDao());
builder.AdicionaAcao(new SMSSender());

NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                    .ComCnpj("123.456.789/0001-10")
                    .ComItem(new ItemDaNota("item 1", 100.0))
                    .ComItem(new ItemDaNota("item 2", 200.0))
                    .ComItem(new ItemDaNota("item 3", 300.0))
                    .ComObservacoes("entregar notaFiscal pessoalmente")
                    .Constroi();
