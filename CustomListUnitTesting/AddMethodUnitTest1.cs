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
            listOfNumbers1.Add(number);
            actualResult = listOfNumbers1.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
       
        public void Add_CountIncreases_ByTwo()
        {
            //Arange
            CustomList<int> listOfNumbers2 = new CustomList<int>();
            int number = 12;
            int expectedResult = 2;
            int actualResult;
            //Act
            listOfNumbers2.Add(number);
            actualResult = listOfNumbers2.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
       
        public void Add_String_Increases_One()
        {
            //Arange
            CustomList<string> listOfString = new CustomList<string>();
            string item = "soccer ball";
            string expectedResult = "soccer ball";
            string actualResult;
            //Act
            listOfString.Add(item);
            actualResult = listOfString.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void Add_String_Increases_Two()
        {
            //Arrange
            CustomList <string> listOfItem= new CustomList<string>();
            string item2 = "baseball";
            string expectedResult = "baseball";
            string actualResult;
            //Act
            listOfItem.Add(item2);
            actualResult = listOfItem.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void Add_Double_Increases_ByDecimal()
        {
            //Arrange
            CustomList<double> dollarAmount = new CustomList<double>();
            double amount = 10;
            double expectedResult = 2.50;
            string actualResult;
            //Act
            dollarAmount.Add(amount);
            actualResult = dollarAmount.count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}