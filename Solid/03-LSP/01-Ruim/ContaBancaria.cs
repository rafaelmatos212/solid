using System.Security.Cryptography.X509Certificates;

namespace Solid._03_LSP._01_Ruim
{
    public class ContaBancaria
    {
        public virtual void Sacar(decimal valor)
        {
            Console.WriteLine($"Saque de {valor} realizado.");
        }

        public void Emprestimo(decimal valor)
        {
            Console.WriteLine($"Empréstimo de {valor} realizado.");
        }
    }

    public class ContaPoupanca : ContaBancaria
    {
        public decimal Saldo { get; set; }

        public override void Sacar(decimal valor)
        {
            // Implementação específica para Conta Poupança sobrescreve o método
            // que pode não ser adequada para o comportamento esperado de ContaBancaria
            if (valor < Saldo)
                throw new Exception("Saldo insuficiente");

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado.");
        }

        public void Emprestimo(decimal valor)
        {
            // Conta Poupança não deve ter empréstimo, mas o método está presente na classe base
            throw new NotSupportedException("Empréstimos não são suportados em Conta Poupança.");
        }
    }
}