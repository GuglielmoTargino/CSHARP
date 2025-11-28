namespace ExecAula2
{

    public class ContaBancaria
    {
        private double saldo = 0;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();
            c.Depositar(1500);
            Console.WriteLine($"Saldo atual: {c.ConsultarSaldo()}");
            c.Depositar(-1500);
            Console.WriteLine($"Saldo atual: {c.ConsultarSaldo()}");
        }
    }
}
