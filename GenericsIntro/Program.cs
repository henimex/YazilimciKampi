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

            Console.WriteLine(benimListem.Length);

            benimListem.Add("Dilek");
            Console.WriteLine(benimListem.Length);


            foreach (var item in benimListem.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
