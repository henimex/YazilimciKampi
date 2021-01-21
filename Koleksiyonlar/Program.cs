using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new[] {"engin", "ferhat", "mehmet", "celil"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);


            List<string> uyeler = new List<string>();
            uyeler.Add("Ferhat");
            uyeler.Add("Dilek");
            uyeler.Add("Esila");
            uyeler.Add("Ali Alp");
            uyeler.Add("Tugrul");

            foreach (var item in uyeler)
            {
                Console.WriteLine(item);
            }

            //List<string> isimler = new List<string>{"Ahmet", "Mehmet", "Ferhat", "Ali"};
            //Console.WriteLine(isimler[0]);
            //isimler.Add("Mahmut");

        }
    }
}
