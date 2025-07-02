using Solid._01_SRP.Bom;
using Solid._02_OCP._02_Bom;
using Solid._03_LSP._02_Bom;
using Solid._05_DIP._01_Ruim;
using Solid._05_DIP._02_Bom;
using Solid._06_Bonus;

public class Program
{
    public static void Main(string[] args)
    {
        // SRP
        Relatorio relatorio = new Relatorio();
        ImpressaoService impressaoService = new ImpressaoService();
        RelatorioRepository relatorioRepository = new RelatorioRepository();

        relatorio.Gerar();
        impressaoService.Imprimir(relatorio);
        relatorioRepository.Salvar(relatorio);


        // OCP
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar(100.0m);
        //
        Pagamento pagamentoPix;
        pagamentoPix = new PagamentoPix();
        pagamentoPix.Pagar(200.0m);

        // LSP
        ContaBancaria contaBancaria;
        contaBancaria = new ContaCorrente();
        //contaBancaria = new ContaPoupanca();



        // DIP
        // -- Ruim
        var emailService = new EmailServiceRuim();
        var fakeEmailService = new FakeEmailServiceRuim();
        var userService = new UserServiceRuim(emailService);
        var userService2 = new UserServiceRuim(fakeEmailService);
        // UserService depende de EmailService diretamente,
        // o que é ruim para testes e manutenção pois não consigo mockar.

        // -- Bom
        var emailServiceBom = new EmailService();
        var outroEmailService = new FakeEmailService();
        var userServiceBom = new UserService(emailServiceBom);
        var outroUserService = new UserService(outroEmailService);


        // Bônus
        var cavalo = new Cavalo();
        cavalo.EmitirSom(); // Saída: Som genérico de animal.
    }



}