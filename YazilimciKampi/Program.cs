using System;

namespace YazilimciKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (sistemeGirisYapmismi)
            {
                Console.WriteLine("sisteme giriş yapıldı");
                Console.WriteLine(kategoriEtiketi + " " + ogrenciSayisi);
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapılmadı");
                Console.WriteLine("Üye ol butonu aktif");
            }

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
                Console.WriteLine(faizOrani);
            }


            
        }
    }
}
