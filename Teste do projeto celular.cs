using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone

        // Teste com Nokia
        Nokia nokia = new Nokia("123456789");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Teste com iPhone
        Iphone iphone = new Iphone("987654321", "iPhone 12", "iOS 15");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
