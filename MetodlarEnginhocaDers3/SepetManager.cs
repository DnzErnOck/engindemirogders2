using System;
using System.Collections.Generic;
using System.Text;

namespace MetodlarEnginhocaDers3
{
    class SepetManager
    {
        //naming convention (yazma tekniği -metodun ilk harfi büyük yazılır.)
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi."+urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete Ekle" + urunAdi);
        }


    }
}
