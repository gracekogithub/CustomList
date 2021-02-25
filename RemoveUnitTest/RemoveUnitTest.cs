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
            items.AddMyItem(number);

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
            int expectedResult = 1;
            int actualResult;
            //Act
            names.AddMyItem(name1);
            names.AddMyItem(name2);
            names.AddMyItem(name3);
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
            CustomList<string> reNames = new CustomList<string>();
            string name1 = "tennis ball";
            string name2 = "golf ball";
            string name3 = "soccer ball";
            int expectedResult = 4;
            int actualResult;
            //Act
            reNames.AddMyItem(name1);
            reNames.AddMyItem(name2);
            reNames.AddMyItem(name3);
            reNames.RemoveItem(name1);
            reNames.RemoveItem(name2);
            reNames.RemoveItem(name3);
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
           
            int expectedResult = 15;
            int actualResult;
            //Act
            item.AddMyItem(item1);
            item.AddMyItem(item2);
            item.AddMyItem(item3);
            item.RemoveItem(item3);
            actualResult = item[1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        //[TestMethod]
        //public void Remove_all()
        //{
        //    //Arrange
        //    CustomList<int> allNumbers = new CustomList<int>();
        //    int allNumber1 = 10;
        //    int allNumber2 = 40;
        //    int allNumber3 = 50;
        //    int allNumber4 = 60;
        //    int expectedResult = 0;
        //    int actualResult;
        //    //Act
        //    allNumber1.RemoveItem.Clear();
        //    actualResult = allNumbers.Count;
        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
       
    }
}
