namespace Solid._02_OCP._01_Ruim
{
    public enum PagamentoType
    {
        Boleto = 0,
        CartaoCredito = 1,
        CartaoDebito = 2,
        Pix = 3
    };

    public class Pagamento
    {
        public decimal Pagar(PagamentoType tipo, decimal valor)
        {
            if (tipo == PagamentoType.Boleto)
                return valor - (valor * 0.1M);
            
            if (tipo == PagamentoType.CartaoCredito)
                return valor * 0.05M;

            if (tipo == PagamentoType.CartaoDebito)
                return valor * 0.02M;

            if (tipo == PagamentoType.Pix)
                return valor - (valor * 0.01M);

            return valor;
        }

        // Se um novo tipo de produto for adicionado,
        // você precisará modificar esta função, violando o princípio Aberto/Fechado
    }
}
