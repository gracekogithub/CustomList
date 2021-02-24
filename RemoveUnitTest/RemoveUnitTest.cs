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
            int expectedResult = 0;
            int actualResult;
            //Act
            items.RemoveItem(number);
            actualResult = items.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_CountString_Decrease_ByTwo()
        {
            //Arrange
            CustomList<string> names = new CustomList<string>();
            string name1 = "tennis ball";
            string name2 = "golf ball";
            string name3 = "soccer ball";
            int expectedResult = 2;
            int actualResult;
            //Act
            names.RemoveItem(name1);
            names.RemoveItem(name2);
            actualResult = names.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_CapacityString_Decrease_ByThree()
        {
            //Arrange
            CustomList<string> removeNames = new CustomList<string>();
            string name1 = "tennis ball";
            string name2 = "golf ball";
            string name3 = "soccer ball";
            int expectedResult = 0;
            int actualResult;
            //Act
            removeNames.RemoveItem(name1);
            removeNames.RemoveItem(name2);
            removeNames.RemoveItem(name3);
            actualResult = removeNames.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_OneItem_FromFive()
        {
            //Arrange
            CustomList<int> item = new CustomList<int>();
            int item1 = 11;
            int item2 = 15;
            int item3 = 20;
            string item4 = "tennis ball";
            string item5 = "golf ball";
            int expectedResult = 30;
            int actualResult;
            //Act
            item.RemoveItem(item3);
            actualResult = item[2];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
       
    }
}
