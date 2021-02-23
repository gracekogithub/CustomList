using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListNew
{
    public class CustomList<T>
    {
        //private T[] _price;
        //private T[] _sportsBalls;
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
            //Array.Resize<T>(ref _items, 4);
            
        }
        public void AddMyItem (T numberToAdd)
        {
            if (count == capacity)
            {
                Array.Resize(ref _items, count + 4);
               
            }
            else 
            {
                _items[count] = numberToAdd;
                count++;
            }
            
        }
       
    }
}
