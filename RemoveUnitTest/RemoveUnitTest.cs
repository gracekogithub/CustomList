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
            string expectedResult = "tennis ball" + "golf ball";
            string actualResult;
            //Act
            names.RemoveItem(name1);
            names.RemoveItem(name2);
            actualResult = Convert.ToInt32(names.Count);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_Capacity_Decrease_ByOne()
        {
            //Arrange
            CustomList<int> numberCap = new CustomList<int>();
            int numberCap1 = 11;
            int expectedResult = 4;
            int actualResult;
            //Act
            numberCap.RemoveItem(numberCap1);
            actualResult = numberCap.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
