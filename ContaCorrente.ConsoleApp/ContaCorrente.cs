using System.Collections;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public int Numero { get; set; }
        public double Limite { get; set; }
        public bool Especial { get; set; }

        public ArrayList Movimentacoes = new ArrayList();

        public ContaCorrente(double saldo, int numero, double limite, bool especial)
        {
            Saldo = saldo;
            Numero = numero;
            Limite = limite;
            Especial = especial;
            Movimentacoes = new ArrayList();
        }

        public void Sacar(double valor, string tipo)
        {
            double limiteSaque = Limite + Saldo;

            if (valor > limiteSaque)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Movimentacao movimentacao = new Movimentacao(-valor, tipo);
                Movimentacoes.Add(movimentacao);
                Saldo = Saldo - valor;
            }
        }

        public void Depositar(double valor, string tipo)
        {
            Saldo += valor;
            Movimentacao movimentacao = new Movimentacao(valor, tipo);
            Movimentacoes.Add(movimentacao);
        }
        public void VerSaldo()
        {
            Console.WriteLine("Saldo atual: R$" + Saldo);
            Console.WriteLine();
        }
        public void VerExtrato()
        {
            foreach (Movimentacao movimentacao in Movimentacoes)
            {
                Console.WriteLine("Valor: " + movimentacao.Valor);
                Console.WriteLine("Tipo: " + movimentacao.Tipo);
                Console.WriteLine();
            }
        }
        public void Transferir(ContaCorrente contaDestino, double valor, string tipo)
        {
            Sacar(valor, tipo);
            contaDestino.Depositar(valor, tipo);

            Console.WriteLine($"Valor enviado: R${valor}");
        }
    }
}

