namespace StatePattern
{
    public class SaldoNegativo : EstadoDaConta
    {
        public void Depositar(ContaBancaria contaBancaria, double valor)
        {
            contaBancaria.Saldo += (0.95 * valor);
            if (contaBancaria.Saldo >= 0)
                contaBancaria.EstadoAtual = new SaldoPositivo();
        }

        public void Sacar(ContaBancaria contaBancaria, double valor)
        {
            Console.WriteLine("Conta no vermelho. Não é possível sacar.");
        }
    }
}