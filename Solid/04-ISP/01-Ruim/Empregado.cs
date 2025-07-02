namespace Solid._04_ISP._01_Ruim
{
    public interface Empregado
    {
        public string Nome { get; set; }
        public void CalcularSalario();
        public void ContratarFuncionario();
    }

    public class Gerente : Empregado
    {
        public string Nome { get; set; }
        
        public void CalcularSalario()
        {
            Console.WriteLine("Calculando salário do gerente...");
        }
        public void ContratarFuncionario()
        {
            Console.WriteLine("Contratando funcionário...");
        }
    }

    public class Vendedor : Empregado
    {
        public string Nome { get; set; }
        
        public void CalcularSalario()
        {
            Console.WriteLine("Calculando salário do vendedor...");
        }

        public void ContratarFuncionario()
        {
            throw new NotImplementedException("Vendedor não pode contratar funcionários.");
        }
    }
}
