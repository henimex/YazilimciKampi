using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class NewList<T>
    {
        T[] items;

        public NewList()
        {
            items = new T[0];
            Console.WriteLine("Constructor newlendiginde calısır ! You musnt forget this rule. It will save your life.");
        }

        public void Add(T item)
        {

        }
    }
}
