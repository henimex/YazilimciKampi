using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            Console.WriteLine("MYList Constructoru Çalıştı");
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //bu işlemin neden yapıldıgını anlamadım 

        }
    }
}
