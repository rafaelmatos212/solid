namespace Solid._05_DIP._02_Bom
{
    public interface IEmailService
    {
        void Enviar(string mensagem);
    }


    public class EmailService : IEmailService
    {
        public void Enviar(string mensagem)
        {
            // Lógica para enviar email
            Console.WriteLine("Enviando email");
        }
    }

    public class FakeEmailService : IEmailService
    {
        public void Enviar(string mensagem)
        {
            // Lógica para enviar email
            Console.WriteLine("Email de teste");
        }
    }


    public class UserService(IEmailService service)
    {

    }
}
