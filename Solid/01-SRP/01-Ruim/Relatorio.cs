namespace Solid._01_SRP.Ruim
{
    public class Relatorio
    {
        public void Gerar()
        {
            Console.WriteLine("Gerando relatório...");
            Imprimir();
            Salvar();
        }

        // Violação do Princípio da Responsabilidade Única (SRP)
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório...");
        }

        public void Salvar()
        {
            Console.WriteLine("Salvando relatório...");
        }
    }
}
