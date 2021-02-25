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
            CustomList<int> listOfNumbers1 = new CustomList<int>();  //empty list[      ]
            int number = 9;
            int expectedResult = 1;
            int actualResult;

            //Act
            listOfNumbers1.AddMyItem(number);  //list with one value     [9 , , , ]
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
            listOfNumbers2.AddMyItem(number1);
            listOfNumbers2.AddMyItem(number2);
            actualResult = listOfNumbers2.Capacity;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestMethod]
        public void Add_String_Increases_One()
        {
            //Arange
            CustomList<string> listOfString1 = new CustomList<string>();
            string item1 = "soccer ball";
            string item2 = "tennis ball";
            string item3 = "golf ball";
            string expectedResult = "tennis ball";
            string actualResult;
            //Act
            listOfString1.AddMyItem(item1);
            listOfString1.AddMyItem(item2);
            listOfString1.AddMyItem(item3);
            actualResult = listOfString1[1];
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
            listOfString2.AddMyItem(item1);
            listOfString2.AddMyItem(item2);
            listOfString2.AddMyItem(item3);
            listOfString2.AddMyItem(item4);
            listOfString2.AddMyItem(item5);

            actualResult = listOfString2.Capacity;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_String_Increases()
        {
            //Arrange
            CustomList<string> listOfString2 = new CustomList<string>();
            string item1 = "soccer ball";
            string item2 = "baseball";
            string item3 = "tennis ball";
            string item4 = "tennis racket";
            string item5 = "golf ball";
            string expectedResult = "golf ball";
            string actualResult;
            //Act
            listOfString2.AddMyItem(item1);
            listOfString2.AddMyItem(item2);
            listOfString2.AddMyItem(item3);
            listOfString2.AddMyItem(item4);
            listOfString2.AddMyItem(item5);

            actualResult = listOfString2[4];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
       
    }
}