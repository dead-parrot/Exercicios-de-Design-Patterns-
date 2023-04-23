namespace StatePattern
{
    public interface EstadoDaConta
    {
        void Depositar(ContaBancaria contaBancaria, double valor);

        void Sacar(ContaBancaria contaBancaria, double valor);
    }
}