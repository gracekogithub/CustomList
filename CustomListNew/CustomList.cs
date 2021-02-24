using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _items = new T[_items.Length];
           
            
        }
        public void AddMyItem (T itemAdded)
        {
            if (count == capacity)
            {
                //Array.Resize<T>(ref _items, _items.Length);
                T[] moreItems = new T[_items.Length * 2];
                Array.Copy(_items, moreItems, _items.Length);
                _items = moreItems;
                _items[count++] = itemAdded;
            }
            _items[count++] = itemAdded;
        }
       
    }
}
