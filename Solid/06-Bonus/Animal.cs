namespace Solid._06_Bonus
{
    public abstract class AnimalAbstrato
    {
        public abstract void EmitirSom();
    }

    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico de animal.");
        }
    }

    // -----------------------------------------------------------------

    public class Cachorro : AnimalAbstrato
    {
        // Como a classe Cachorro herda de AnimalAbstrato,
        // ela DEVE implementar o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au!");
        }
    }

    public class Vaca : AnimalAbstrato
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Muu!");
        }
    }



    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }

    public class Cavalo : Animal
    {
        // A classe Gato herda de Animal, mas não é obrigada a sobrescrever o método EmitirSom
        // Ela pode usar a implementação da classe base ou sobrescrever se necessário
    }

    // abstract = "Você DEVE sobrescrever, força implementação"
    // virtual = "Você PODE sobrescrever"
}