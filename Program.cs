using CelularPOOBootcampDIO.Net.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Nokia telefoneNokia = new Nokia("51993010201", "Nokia Asha", "055434HW2", 8);
        Iphone telefoneIphone = new Iphone("51992020214", "Iphone 11", "3232esdsd22", 16);
        
        telefoneNokia.InstalarAplicativo("Joguinho da Cobra");
        telefoneIphone.ReceberLigacao();
        telefoneIphone.InstalarAplicativo("Facebook");

    }
}