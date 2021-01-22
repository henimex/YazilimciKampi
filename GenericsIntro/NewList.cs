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
            Console.WriteLine("Constructor newlendiginde calısır ! You musn't forget this rule. It will save your life.");
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
