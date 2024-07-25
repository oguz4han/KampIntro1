using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class DorIslem
    { 

        public void Topla(int s1,int s2)
        {
            int toplam = s1+s2;
            Console.WriteLine( " Sonu: "+toplam);
        }

        public void ekle(int id,string ad, string soyad)
        {
            Console.WriteLine($"{ad} - {soyad}");
        }

    }
}
