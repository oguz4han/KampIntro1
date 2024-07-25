using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Urun
    {
        public int urunId { get; set; }
        public string urunAd { get; set; }
        public int urunFiyat { get; set; }


        public void bilgilerGoster(int urunId, string urunAd, int urunFiyat)
        {
            Console.WriteLine($"Urun ID: {urunId} \nUrun Ad: {urunAd} \nUrun Fiyat: {urunFiyat} ");
        }

    }


}
