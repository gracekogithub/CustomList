using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListNew;

namespace ToStringUnitTest
{
    [TestClass]
    public class ToStringUnitTest
    {
        [TestMethod]
        public void ToString_Test1()
        {
            //Arrange
            CustomList<int> temp = new CustomList<int>();
            int number = 20;
            string expectedResult = "20";
            string actualResult;
            //Act
            
            temp.ToStringMethodTest(number);
            actualResult = temp.ToString;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
