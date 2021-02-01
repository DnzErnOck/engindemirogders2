using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //demekki interfacelerde o inferface'i implemente eden sınıfın referans tipini tutabiliyorm uş

            ILoggerService databaseLoggerService = new DateBaseLoggerService();
            ILoggerService fileBaseLoggerService = new FileBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),new List<ILoggerService> { databaseLoggerService,fileBaseLoggerService});


            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager,ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
