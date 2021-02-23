using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListNew
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myIntList = new List<int>();
            myIntList.Add(9);
            myIntList.Add(12);
            myIntList.Add(20);
            myIntList.Add(11);
            myIntList.Add(15);

            myIntList.Capacity = 5;
            int myNumber = myIntList[0];
            int[] myNumber2 = new int[4];

        }
    }
}
