using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;

namespace ToStringMethodTest
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]
        public void ChangeIntToStringTest_CheckIndex0()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            string expected = "2510";
            string actual;

            //Act
            items.Add(2);
            items.Add(5);
            items.Add(10);

            actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ChangeDoubleToStringTest_CheckCount()
        {
            //Arrange
            CustomList<double> items = new CustomList<double>();
            double num1 = 24.4;
            int expected = 1;
            int actual;

            //Act
            items.Add(num1);
            actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
