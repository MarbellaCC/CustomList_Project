using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        //member variables
        private T[] items;
        public int Count;
        public int Capacity;


        public T this[int i] => items[i];

        //constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }



        //member methods
        public void Add(T item)
        {
            // GOAL: add an item to my list

            // First step: Add the item to my array
            // Second step: Count goes up when you add an item
            // Third step: once Count reaches a certain capacity, TROUBLE!
            // Plan of Action: we need to double capacity once we reach original capacity

            // Idea! TEMPORARY ARRAY!?!?!?!
            // Temporary array would be twice the size of the original
            // all values from original go to the temp
            // original is set equal to the temp!


            if (Count < Capacity)
            {
                items[Count++] = item;

            }
            else if (Count >= Capacity)
            {
                //need to create new array with more spots (capacity)
                //transefer over old items into new array
                Capacity *= 2;
                T[] tempItems = new T[Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    tempItems[i] = items[i];
                }
                tempItems[Count++] = item;
                items = tempItems;
            }
        }

        public void Remove(T item)
        {

            // List of numbers 1 2 3 4 5 6
            // remove 3
            // find 3
            // when I find it, shift everything past it down one spot
            // 1 2 4 5 6
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    items[i] = items[i + 1];
                }
            }


            // go through the array
            // WHEN I find the item I'm looking for, start this process
            // once I hit the final item, how do I deal with an out of bounds exception?




        }

       
    
        



    }
}
