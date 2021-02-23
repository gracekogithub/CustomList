using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListNew;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddMethodUnitTest1
    {

        [TestMethod]
        public void Add_CountIncreases_ByOne()
        {
            //Arange
            CustomList<int> listOfNumbers1 = new CustomList<int>();
            int number = 9;
            int expectedResult = 1;
            int actualResult;

            //Act
            listOfNumbers1.AddMyItem(number);
            actualResult = listOfNumbers1.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
       [TestMethod]
        public void Add_CountIncreases_ByTwo()
        {
            //Arange
            CustomList<int> listOfNumbers2 = new CustomList<int>();
            int numberOfCapacity = 5;
            int expectedResult = 10;
            int actualResult;
            //Act
            listOfNumbers2.AddMyItem(numberOfCapacity);
            actualResult = listOfNumbers2.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_String_Increases_One()
        {
            //Arange
            CustomList<string> listOfString1 = new CustomList<string>();
            string item = "soccer ball";
            string expectedResult = "soccer ball";
            string actualResult;
            //Act
            listOfString1.AddMyItem(item);
            actualResult = listOfString1.Capacity("soccer ball", listOfString1.Count+1);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_String_Increases_Two()
        {
            //Arrange
            CustomList<string> listOfString2 = new CustomList<string>();
            string item1 = "soccer ball";
            string item2 = "baseball";
            string expectedResult = item1 +item2;
            string actualResult;
            //Act
            listOfString2.AddMyItem(item1 + item2);
            actualResult = listOfString2.Count(item1+item2);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_ItemsValue()
        {
            //Arrange
            CustomList<double> listOfValue = new CustomList<double>();
            
            double expectedResult=10.5;
            double actualResult;
            //Act
            actualResult = listOfValue.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}