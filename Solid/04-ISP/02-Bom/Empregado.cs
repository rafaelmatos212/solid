namespace Solid._04_ISP._02_Bom
{
    // Interfaces segregadas para diferentes responsabilidades
    public interface ICalcularSalario
    {
        void CalcularSalario();
    }

    public interface IContratarFuncionario
    {
        void ContratarFuncionario();
    }

    // Classes que implementam as interfaces segregadas
    public class Gerente : ICalcularSalario, IContratarFuncionario
    {
        public string Nome { get; set; } = string.Empty;

        public void CalcularSalario()
        {
            Console.WriteLine("Calculando salário do gerente...");
        }
        public void ContratarFuncionario()
        {
            Console.WriteLine("Gerente contratando funcionário...");
        }
    }

    public class Vendedor : ICalcularSalario
    {
        public string Nome { get; set; } = string.Empty;

        public void CalcularSalario()
        {
            Console.WriteLine("Calculando salário do vendedor...");
        }
        // Vendedor não implementa IContratarFuncionario,
        // pois não pode contratar funcionários.
    }
}
