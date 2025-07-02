namespace Solid._05_DIP._01_Ruim
{
    public class EmailServiceRuim
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando email");
        }
    }

    public class FakeEmailServiceRuim
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando email");
        }
    }

    public class UserServiceRuim(EmailServiceRuim service)
    {
        
    }
}
