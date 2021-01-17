using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Ferhat";
            int yas = 37;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Gelistirme Kampı";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOranı = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Kenan";
            kurs2.IzlenmeOranı = 20;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Kotlin";
            kurs3.Egitmen = "Atıl Samancı";
            kurs3.IzlenmeOranı = 10;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.Egitmen = "Cengiz";
            kurs4.IzlenmeOranı = 23;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};

            Console.WriteLine("------------------");
            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
                Console.WriteLine(item.Egitmen);
                Console.WriteLine(item.IzlenmeOranı);
                Console.WriteLine("------------------");
            }



        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
