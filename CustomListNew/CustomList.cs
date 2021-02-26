using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomListNew
{
    public class CustomList<T>
    {
        private T[] _items = new T[4];
        public T this[int i]
        {
            get
            {
                return _items[i];
            }
            set
            {
                _items[i] = value;
            }
        }
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
        
        
        
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
           
            
        }
        public void AddMyItem (T itemAdded)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] moreItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    moreItems[i] = _items[i];
                }
                _items = moreItems;
            }
            _items[count] = itemAdded;
            count++;
        }
        public void RemoveItem(T myItems)
        {
            AddMyItem(myItems);
            T[] temp = new T[count];
            for (int i = 0; i < count; i++)
            {
                temp[i] = _items[i];
            }
            _items[count] = myItems;
            count--;
        }
        //Don't Remove, but create new collection without item being removed
        public void ReadFile()
        {
            string path = @"Mac\Home\Desktop\DevCode\CustomListNew\TestFile.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Error: File does not exist");
            }
        }
    }
}
