using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        private T[] items = new T[4];
        public int Count = 0;
        public int Capacity = 4;

        public void Add(T item)
        {
            if(Count < Capacity)
            {
                items[Count] = item;
                Count++;
            }
            else if(Count >= Capacity)
            {
                Capacity = Capacity * 2;
                items[Count] = item;
                Count++;
                
            }
        }

        public void Remove(T item)
        {
            items[Count] = item;
            Count--;
        }

        public string ConvertToString(T item)
        {
            //if item being passed in isnt string convert to string and then add item to list
            return String.Format("{0}", item);
        }

    }
}
