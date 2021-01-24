using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] array; 
        T[] tempArray;

        public MyDictionary()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }

            array[array.Length - 1] = item;
        }

        public int Length
        {
            get { return array.Length; }
        }

        public T[] Student
        {
            get { return array; }
        }
    }
}
