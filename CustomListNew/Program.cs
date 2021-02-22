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
            myIntList.Add(1);
            myIntList.Add(2);
            myIntList.Add(3);
            myIntList.Add(4);
            myIntList.Add(5);

            myIntList.Capacity = 10;
            int myNumber = myIntList[0];
            int[] myNumber2 = new int[4];

        }
    }
}
