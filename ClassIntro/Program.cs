using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Urun urun1 = new Urun();
            urun1.urunId = 1;
            urun1.urunAd = "Araba";
            urun1.urunFiyat = 250;

            Urun urun2 = new Urun();
            urun2.urunId = 2;
            urun2.urunAd = "Atv";
            urun2.urunFiyat = 190;

            Urun urun3 = new Urun();
            urun3.urunId = 3;
            urun3.urunAd = "Bisiklet";
            urun3.urunFiyat = 50;

            Urun[] urunler = new Urun[] { urun1, urun2 , urun3};

            Console.WriteLine("-----------FOR---------------");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Urun ID:" + urunler[i].urunId + "\nUrun Ad:" + urunler[i].urunAd + "\nUrun Fiyat: " + urunler[i].urunFiyat);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("-----------While---------------");
            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine("Urun ID:" + urunler[x].urunId + "\nUrun Ad:" + urunler[x].urunAd + "\nUrun Fiyat: " + urunler[x].urunFiyat);
                Console.WriteLine("--------------------------");
                x++;
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("-----------Foreach---------------");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urun ID:" + urun.urunId + "\nUrun Ad:" + urun.urunAd + "\nUrun Fiyat: " + urun.urunFiyat);
            }
            Console.WriteLine("\n\n");







            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
