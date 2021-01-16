using System;

namespace engindemirogders2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizOrani = 1.15;
            bool sistemeGirisYapılmısMi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("aZALIŞ");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("artıs");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapılmısMi == true)
            {
                Console.WriteLine("Kullanıcı Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
