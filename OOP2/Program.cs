using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //engin demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "154786465";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demir";
            musteri1.TcNo = "4545456464";

            //tuzel musteri-kodlaama ıo

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "65665";
            musteri2.SirketAdi = "Kodlamaıo";
            musteri2.VergiNo = "4564656464";
            //Gerçek Musteri-Tuzel Musteri 
            //tiplweri farklı o yuzden birbirnin yerine kullanılamaz

            //msuteri sınıfı hem gerçek musteri hemde tuzel musteri sınıfının referansını tutabiliyor.
            Musteri musteri3 =new GercekMusteri();

            Musteri musteri4 = new TuzelMusteri();

           
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);


        }
    }
}
