using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "ELMA";
            urun1.Fiyati = 9.65;
            urun1.Aciklama = "Organik Elma";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "ARMUT";
            urun2.Fiyati = 2.65;
            urun2.Aciklama = "Organik Armut";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
            }

            SepetManager sm = new SepetManager();
            sm.Ekle(urun1);
            sm.Ekle(urun2);

            //sm.yeniEkle("Armut", "Deveci", 6.25);


        }
    }
}
