using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_ArrayHelper
{
    public class ArrayHelper<T>
        where T:IEquatable<T>
    {
        public ArrayHelper(T[] array)
        {
            Array = array;
        }
        public T[] Array { get;}

        public int ReturnIndex(T searchedValue)
        {
            int index=0;

            if(searchedValue is null)
            {
                index=-1;
            }

            bool isPresentInArray = Array.Contains(searchedValue);

            if (isPresentInArray)
            {
                for(int i = 0; i < Array.Length; i++)
                {
                    //implements IEquateble<T> => can use method Equals
                    if (Array[i].Equals(searchedValue))
                    {
                        index = i;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Elementul {searchedValue} nu este continut in sir.");
                index=-1;
            }

            return index;
        }

        public T[] ReturnArray(int indexStart, int length)
        {
            if(indexStart<0 && length < 0)
            {
                return new T[0];
            }

            T[] resultedArray = new T[length];

            int j = 0;

            for(int i = indexStart; i < indexStart+length; i++)
            {
                resultedArray[j] = Array[i];
                j++;
            }

            return resultedArray;
        }

    }
}
