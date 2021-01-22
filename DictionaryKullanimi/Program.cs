using System;
using System.Collections.Generic;

namespace DictionaryKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();

            Console.WriteLine(cities.MyDicCount);

            cities.Add(101, "Adana");
            cities.Add(102, "Adıyaman");
            cities.Add(103, "Afyon");
            cities.Add(104, "Ağrı");
            cities.Add(105, "Amasya");
            cities.Add(126, "Eskişehir");
            cities.Add(134, "İstanbul");
            Console.WriteLine(cities.MyDicCount);

            Console.WriteLine("{0} Cities are registered to new Licence System\nTheese are:",cities.MyDicCount);
            foreach (var city in cities.CityNames)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("Registered City Codes Are: (byOrder)");
            foreach (var code in cities.CityCodes)
            {
                Console.WriteLine(code);
            }
        }
    }
}
