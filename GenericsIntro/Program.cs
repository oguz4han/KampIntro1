
using GenericsIntro;



// Örnek bir array (dizi)
int[] yaslar = new int[] {15,13,17,12,11,16};


// Örnek bir liste
List<string> adlar = new List<string> { "oğuz", "veli", "ahmet" };




MyList<string> isimler = new MyList<string>();



int[] sayi1 = new int[] { 1,2,3,4};
int[] sayi2 = new int[] { 10, 20, 30, 40 };

sayi1 = sayi2;
sayi2[0] = 100;

Console.WriteLine(sayi1[0]);