using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DictionaryKullanimi
{
    public class MyDictionary<T, Y>
    {

        T[] _cityCode;
        T[] _tempCityCode;
        Y[] _cityName;
        Y[] _tempCityName;

        public MyDictionary()
        {
            _cityCode = new T[0];
            _cityName = new Y[0];
        }

        public void Add(T cityCode, Y cityName)
        {
            _tempCityCode = _cityCode;
            _cityCode = new T[_cityCode.Length + 1];
            _tempCityName = _cityName;
            _cityName = new Y[_cityName.Length + 1];

            for (int i = 0; i < _tempCityCode.Length; i++)
            {
                _cityCode[i] = _tempCityCode[i];
            }
            _cityCode[_cityCode.Length - 1] = cityCode;

            for (int i = 0; i < _tempCityName.Length; i++)
            {
                _cityName[i] = _tempCityName[i];
            }
            _cityName[_cityName.Length - 1] = cityName;
        }

        public int MyDicCount
        {
            get { return _cityCode.Length; }
        }

        public T[] CityCodes
        {
            get { return _cityCode; }
        }

        public Y[] CityNames
        {
            get { return _cityName; }
        }

        #region Aynı anda hem key hemde value alma denemesi
        /*
        public T[],Y[] keyV
        {
            get { return _cityName; }
            get { return _cityCode; }
        }

        public struct Enumerator : IEnumerator<KeyValuePair<T, Y>>, IEnumerator, IDisposable, IDictionaryEnumerator
        {
            public KeyValuePair<T, Y> Current => throw new NotImplementedException();

            public DictionaryEntry Entry => throw new NotImplementedException();

            public object Key => throw new NotImplementedException();

            public object Value => throw new NotImplementedException();

            object System.Collections.IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
        */
        #endregion

    }
}
