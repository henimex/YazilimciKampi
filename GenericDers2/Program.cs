using System;
using System.Collections.Generic;

namespace GenericDers2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Eskişehir");
            sehirler.Add("Eskişehir");
            sehirler.Add("Eskişehir");
            sehirler.Add("Eskişehir");
            sehirler.Add("Eskişehir");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            sehirler2.MyAdd("Ankara");
            Console.WriteLine(sehirler2.MyCount);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void MyAdd(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int MyCount
        {
            get { return _array.Length; }
        }

    }
}
