namespace Solid._03_LSP._02_Bom
{
    // Classe base abstrata porque todas classes que derivam
    // dela devem implementar o método Sacar
    public abstract class ContaBancaria
    {
        public decimal Saldo { get; protected set; }

        // Abstract porque precisa ser sobrescrito por classes derivadas
        // Não altero comportamento pois não tem, ela está delegando uma responsabilidade
        public abstract void Sacar(decimal valor);
    }

    public class ContaPoupanca : ContaBancaria
    {
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
                throw new Exception("Saldo insuficiente");

            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado na Conta Poupança.");
        }
    }

    public class ContaCorrente : ContaBancaria
    {
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
                throw new Exception("Saldo insuficiente");
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado na Conta Corrente.");
        }

        public void Emprestimo(decimal valor)
        {
            if (valor > Saldo * 2)
                throw new Exception("Valor do empréstimo excede o limite permitido.");

            Saldo += valor;
            Console.WriteLine($"Empréstimo de {valor} realizado na Conta Corrente.");
        }
    }
}
