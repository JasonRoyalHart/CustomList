using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomBuiltList<T>
    {
        T[] elements;
        public CustomBuiltList()
        {
   
        }
        public int Count()
        {
            int count = 0;
            if (elements != null)
            {
                foreach (object elem in elements)
                {
                    count++;
                }
                return count;
            }
            else
            {
                return 0;
            }
        }
        public void Add(T toAdd)
        {
            int count = 0;
            T[] newElements = new T[Count() + 1];
            if (elements != null)
            {
                foreach (T elem in elements)
                {
                    newElements[count] = elem;
                    count++;
                }
                newElements[count] = toAdd;
            }
            else
            {
                newElements[0] = toAdd;
            }
            elements = newElements;
        }

        public bool Remove(T toRemove)
        {
            T[] newElements = new T[Count() - 1];
            int count = 0;
            bool found = false;
            int foundIndex = 0;
            foreach (T element in elements)
            {
                if (element.Equals(toRemove))
                {
                    found = true;
                    foundIndex = count;
                }
                count++;
            }
            if (found)
            {
                count = 0;
                int newCount = 0;
                foreach (T element in elements)
                {
                    if (count != foundIndex)
                    {
                        newElements[newCount] = element;
                        count++;
                        newCount++;
                    }
                    else
                    {
                        count++;
                    }
                }
                elements = newElements;
                return true;
            }
            else
            {
                Console.WriteLine("{0} was not found in CustomList.",toRemove);
                return false;
            }
        }
        public override string ToString()
        {
            string convertedString = "";
            foreach (T element in elements)
            {
                convertedString += element;
            }
            return convertedString;
        }
        public static CustomBuiltList<T> operator +(CustomBuiltList<T> customListOne, CustomBuiltList<T> customListTwo)
        {
            CustomBuiltList<T> mergedCustomBuiltList = new CustomBuiltList<T>();
            foreach (T element in customListOne.elements)
            {
                mergedCustomBuiltList.Add(element);
            }
            foreach (T element in customListTwo.elements)
            {
                mergedCustomBuiltList.Add(element);
            }
            return mergedCustomBuiltList;
        }
        public void Display()
        {
            if (elements != null)
            {
                foreach (object elem in elements)
                {
                    Console.WriteLine(elem);
                }
            }
            else
            {
                Console.WriteLine("Null list.");
            }
        }
    }
}
