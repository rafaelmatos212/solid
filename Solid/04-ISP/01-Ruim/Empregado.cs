namespace Solid._04_ISP._01_Ruim
{
    public interface Empregado
    {
        public void CalcularSalario();
        public void ContratarFuncionario();
        public void DemitirFuncionario();
    }

    public class Gerente : Empregado
    {
        public string Nome { get; set; } = string.Empty;
        
        public void CalcularSalario()
        {
            Console.WriteLine("Calculando salário do gerente...");
        }
        public void ContratarFuncionario()
        {
            Console.WriteLine("Contratando funcionário...");
        }
        public void DemitirFuncionario()
        {
            Console.WriteLine("Demitindo funcionário...");
        }
    }

    public class Vendedor : Empregado
    {
        public string Nome { get; set; } = string.Empty;
        
        public void CalcularSalario()
        {
            Console.WriteLine("Calculando salário do vendedor...");
        }

        public void ContratarFuncionario()
        {
            throw new NotImplementedException("Vendedor não pode contratar funcionários.");
        }
        public void DemitirFuncionario() {
            throw new NotImplementedException("Vendedor não pode demitir funcionários.");
        }
    }
}
