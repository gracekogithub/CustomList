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
            int number1 = 5;
            int number2 = 10;
            int expectedResult = 4;
            int actualResult;
            //Act
            listOfNumbers2.AddMyItem(number1+number2);
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
            int expectedResult = 4;
            int actualResult;
            //Act
            listOfString1.AddMyItem(item);
            actualResult = listOfString1.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestMethod]
        public void Add_String_Increases_Five()
        {
            //Arrange
            CustomList<string> listOfString2 = new CustomList<string>();
            string item1 = "soccer ball";
            string item2 = "baseball";
            string item3 = "tennis ball";
            string item4 = "tennis racket";
            string item5 = "golf ball";
            int expectedResult = 8;
            int actualResult;
            //Act
            listOfString2.AddMyItem(item1 + item2 + item3 + item4 + item5);
            actualResult = listOfString2.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_ItemsValue()
        {
            CustomList<string> listOfString3 = new CustomList<string>();
            string item1 = "soccer ball";
            string item2 = "baseball";
            string item3 = "tennis ball";
            string item4 = "tennis racket";
            string item5 = "golf ball";
            int expectedResult = 5;
            int actualResult;
            //Act
            listOfString3.AddMyItem(item1 + item2 + item3 + item4 + item5);
            actualResult = listOfString3.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
    }
}