// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Console.WriteLine("Hello, World!");

/*
 * 
Projeniz şunu yapacak.

Bir bankada müşteri takibi yapmak istiyorsunuz.
Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.

*/



Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.name = "Oğuzhan";
musteri1.lastName = "Çakmak";

MusteriManager manager = new MusteriManager();
manager.MusteriEkleme(musteri1);
