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
        private T[] _items;
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
        }
        
        
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
            //_sportsBalls = new T[capacity];
            //_price = new T[capacity];

        }
        public void AddMyItem (T numberToAdd)
        {
            if (count == capacity)
            {

                Array.Resize<T>(ref _items, _items.Length +1);
            }
            else 
            {
                _items[count] = numberToAdd;
                count++;
            }
            
        }
        public void ResizeCapacity(T size)
        {
            if (true)
            {

            }
        }
        //public void AddString(T stringToAdd)
        //{
            
        //    _sportsBalls[count] = stringToAdd;
         
        //}
        //public void AddPriceOfItem (T doubleToAdd)
        //{
        //    _price[count] = doubleToAdd;
        //}
        //public void RemoveMyNumber (T numberToRemove)
        //{
        //    _items[count] = numberToRemove;
        //    count--;
        //}
    }
}
