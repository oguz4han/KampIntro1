using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine($"{musteri.name} adlı musteri eklendi.");
        }

        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri listelendi.");
        }

        public void MusteriSilindi(Musteri musteri)
        {
            Console.WriteLine( musteri.name + " adlı musteri silindi");
        }


    }
}
