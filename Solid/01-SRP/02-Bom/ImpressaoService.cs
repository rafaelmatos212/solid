namespace Solid._01_SRP.Bom
{
    public class ImpressaoService
    {
        // Responsável por imprimir relatórios, independente do tipo,
        // E não da classe especifica na qual estaria acoplada.
        public void Imprimir(Relatorio relatorio)
        {
            Console.WriteLine("Imprimindo relatório...");
        }
    }
}
