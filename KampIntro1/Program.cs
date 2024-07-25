using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tek tek değişken tanımlamamız lazım
            string kurs1 = "Java";
            string kurs2 = "Python";

            object[] kurslar = new object[] {5466,556.4,1,true,"Java","Python","C#","Siemens PLC","Asp.Net","Delta PLC"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-------------------------");
            // dizi temelli yapıları tek tek dönmeye yarar.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.GetType());
            }


            Console.ReadLine();
        }
    }
}
