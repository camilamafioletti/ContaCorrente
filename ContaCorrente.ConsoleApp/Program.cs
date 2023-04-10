namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaX = new ContaCorrente(10000, 1, 15000, true);
            ContaCorrente contaY = new ContaCorrente(12000, 2, 16000, false);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Saldo da Conta X: {contaX.Saldo}");
            Console.ResetColor();

            Console.WriteLine("\nDepositando 5000 ");
            contaX.Depositar(5000, "Deposito");
            contaX.VerSaldo();

            Console.WriteLine("Sacando 7000 ");
            contaX.Sacar(7000, "Credito");
            contaX.VerSaldo();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Transferencia de X para Y: \n");
            Console.ResetColor();
            contaX.Transferir(contaY, 1000, "Transferencia");
            contaX.VerSaldo();

            Console.ForegroundColor = ConsoleColor.DarkYellow;   
            Console.WriteLine("Extrato da conta X: \n");
            Console.ResetColor();
            contaX.VerExtrato();

            Console.WriteLine("-------------------------");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Saldo da Conta Y: {contaY.Saldo}");
            Console.ResetColor();
            Console.WriteLine("\nDepositando 2300 ");
            contaY.Depositar(2300, "Deposito");
            contaY.VerSaldo();
            Console.WriteLine("Sacando 1500 ");
            contaY.Sacar(1500, "Debito");
            contaY.VerSaldo();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Extrato da conta Y: \n ");
            Console.ResetColor();
            contaY.VerExtrato();
        }
    }
}