namespace Solid._02_OCP._02_Bom
{
    public enum PagamentoType
    {
        Boleto = 0,
        CartaoCredito = 1,
        CartaoDebito = 2,
        Pix = 3
    };

    public interface IPagamento
    {
        void Pagar();
    }

    public class Pix : IPagamento
    {
        public void Pagar() => Console.WriteLine("Pagamento realizado via Pix.");
    }

    public class CartaoCredito : IPagamento
    {
        public void Pagar() => Console.WriteLine("Pagamento realizado via Cartão de Crédito.");
    }

    public class CartaoDebito : IPagamento
    {
        public void Pagar() => Console.WriteLine("Pagamento realizado via Cartão de Débito.");
    }

    public class Boleto : IPagamento
    {
        public void Pagar() => Console.WriteLine("Pagamento realizado via Boleto.");
    }

    // ------------------------------------------------------------

    public abstract class Pagamento
    {
        public abstract decimal Pagar(decimal valor);
    }

    public class PagamentoBoleto : Pagamento
    {
        public override decimal Pagar(decimal valor) => valor - (valor * 0.1M);
    }

    public class PagamentoCartaoCredito : Pagamento
    {
        public override decimal Pagar(decimal valor) => valor * 0.05M;
    }

    public class PagamentoCartaoDebito : Pagamento
    {
        public override decimal Pagar(decimal valor) => valor * 0.02M;
    }

    public class PagamentoPix : Pagamento
    {
        public override decimal Pagar(decimal valor) => valor - (valor * 0.01M);
    }
}
