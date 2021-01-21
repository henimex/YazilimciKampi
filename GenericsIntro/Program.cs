using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler = new MyList<string>();

            NewList<string> benimListem = new NewList<string>();
            benimListem.Add("Ferhat");

            NewList<string> ikinciListem;
            ikinciListem.Add("deneme");

            Console.ReadLine();

        }
    }
}
