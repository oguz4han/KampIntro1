using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void güncelle()
        {
            Console.WriteLine("Liste güncellendi.");
        }


        public void Ekle(Urun urun)
        {
            Console.WriteLine($"{urun.Adi} Sepete eklendi.");
        }


    }
}
