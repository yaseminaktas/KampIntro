using System;
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("------Metotlar------");
            Urun urun1 = new Urun();
            urun1.Adi = "karpuz";
            urun1.Fiyati = 15;
            urun1.Aciklama = "diyarbakır karpuzu";



            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("armmut", "yeşil armut", 12);
            
        }
    }
}
