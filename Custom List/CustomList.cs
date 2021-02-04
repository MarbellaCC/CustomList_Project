using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private T[] items;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }



        public T this[int i]
        {
            get
            {
                if (i < 0 && i >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return items[i];
            }
            set
            {
                if (i < 0 && i >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                items[i] = value;
            }
        }

        //constructor
        public CustomList()
        {
            count = 0;
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
                items[count++] = item;
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
                tempItems[count++] = item;
                items = tempItems;
            }
        }

        public void Remove(T item)
        {
            T[] newItems = new T[Capacity];
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                   for (int j = i; j < Count - 1; j++)
                   {
                        newItems[j] = items[i + 1];
                   }
                   break;
                }
                newItems[i] = items[i];
            }
            items = newItems;
            count--;
        }

        public override string ToString()
        {
            string m = "";
            for (int i = 0; i < Count; i++)
            { 
                m += items[i];
            }
            return m;
        }

        public static CustomList<T> operator+(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                result.Add(list2[i]);
            }
            return result;
        }

        public static CustomList<T> operator-(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result;
            result = list1;

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (result[i].Equals(list2[j]))
                    {
                        result.Remove(list2[j]);
                    }
                }
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            //for loop
            ////yield return
            for(int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }
    }
}
