using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>{"Ahmet", "Mehmet", "Ferhat", "Ali"};
            Console.WriteLine(isimler[0]);
            isimler.Add("Mahmut");

        }
    }
}
