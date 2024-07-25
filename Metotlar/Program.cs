// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");


Urun urun1 = new Urun();

urun1.Adi = "Çilek";
urun1.Fiyati = 80;
urun1.Aciklama = "aaaaaaa";

Urun urun2 = new Urun();

urun2.Adi = "Elma";
urun2.Fiyati = 70;
urun2.Aciklama = "bbbbbbb";

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
}

Console.WriteLine("---------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);































