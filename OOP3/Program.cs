


using OOP3;

IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

TasitKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

ILoggerService databaseLoggerService = new DatabaseLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(tasitKrediManager, new  DatabaseLoggerService());


List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
basvuruManager.KrediOnBilgilendirmesiYap(krediler);