// See https://aka.ms/new-console-template for more information
public class ItemDaNota
{
    public String Nome { get; set; }
    public double Valor { get; set; }

    public ItemDaNota(string v1, double v2)
    {
        this.Nome = v1;
        this.Valor = v2;
    }
}