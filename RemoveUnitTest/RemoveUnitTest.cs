using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListNew;

namespace RemoveUnitTest
{
    [TestClass]
    public class RemoveUnitTest
    {
        [TestMethod]
        public void Remove_CountNumber_Decrease_ByOne()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int number = 10;
            int expectedResult = 1;
            int actualResult;
            //Act
            items.RemoveItem(number);
            actualResult = items.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        //public void Remove_CountString_Decrease_ByTwo()
        //{
        //    //Arrange
        //    CustomList<string> names = new CustomList<string>();
        //    string name1 = "tennis ball";
        //    string name2 = "golf ball";
        //    string name3 = "soccer ball";
            
            //Act

            //Assert
        }
    }
}
