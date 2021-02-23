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
            int number = 5;
            int expectedResult = 10;
            int actualResult;
            //Act
            listOfNumbers2.AddMyItem(number);
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
            actualResult = listOfString1.Count();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_String_Increases_Two()
        {
            //Arrange
            CustomList <string> listOfString2= new CustomList<string>();
            string item2 = "baseball";
            string expectedResult = "baseball";
            string actualResult;
            //Act
            listOfString2.AddMyItem(item2);
            actualResult = listOfString2.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Double_Increases_ByDecimal()
        {
            //Arrange
            CustomList<double> dollarAmount = new CustomList<double>();
            double amount = 10;
            double expectedResult = 2.50;
            string actualResult;
            //Act
            dollarAmount.AddMyItem(amount);
            actualResult = dollarAmount.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}