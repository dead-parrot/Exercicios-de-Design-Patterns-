namespace ChainOfResponsibilityPattern.Descontos
{
    public class Item
    {
        public string Name { get; set; }
        public double Preco { get; set; }

        public Item(string name, double preco)
        {
            Name = name;
            Preco = preco;  
        }
    }
}