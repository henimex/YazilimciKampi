using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            void mesajYaz(string mesaj)
            {
                Console.WriteLine("Systemio.Out: " + mesaj);
            }

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine("Yazılacak Sayı : " + i);
            }

            string[] kurslar = new string[] { "Yazılım geliştiric kampı", "Programlamaya başlama temel", "Java", "Python" };

            Console.WriteLine("For ile Döngü Başlangıcı");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i+1 +". Kurs Adı : " + kurslar[i] );
            }
            Console.WriteLine("For ile Döngü Sonu");

            Console.WriteLine("Foreach ile Döngü Başlangıcı");
            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }

            mesajYaz("deneme");

            
        }


    }
}
