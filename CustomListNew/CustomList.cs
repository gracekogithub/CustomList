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
        public T[] Items { get { return _items; } }

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
                //Array.Resize<T>(ref _items, _items.Length);
                T[] moreItems = new T[capacity];
                Array.Copy(_items, moreItems, _items.Length);
                _items = moreItems;
                _items[count++] = itemAdded;
            }
            _items[count++] = itemAdded;
        }
        public void RemoveItem (T createdItem)
        {
            for (int count = 0; count < 4 ; count--)
            {
                _items[count] = _items[count-1];
                if (true)
                {

                }
                else
                {

                }
                
            }
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
