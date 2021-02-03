using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;

namespace ToStringMethodTest
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]
        public void ChangeIntToStringTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            string expected = "2";
            string actual;

            //Act
            items.Add(2);
            actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ChangeDoubleToStringTest()
        {
            //Arrange
            CustomList<double> items = new CustomList<double>();
            double num1 = 24.4;
            string expected = "24.4";
            string actual;

            //Act
            items.Add(num1);
            actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeBoolToStringTest()
        {
            //Arrange
            CustomList<bool> items = new CustomList<bool>();
            bool marbella = true;
            string expected = "True";
            string actual;

            //Act
            items.Add(marbella);
            actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeIntsToString()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int num1 = 24;
            int num2 = 80000;
            string expected = "2480000";
            string actual;

            //Act
            items.Add(num1);
            items.Add(num2);
            actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeCharToString()
        {
            //Arrange
            CustomList<char> items = new CustomList<char>();
            char char1 = 'c';
            char char2 = 'a';
            char char3 = 'm';
            char char4 = 'p';
            char char5 = 'o';
            char char6 = 's';
            string expected = "campos";
            string actual;

            //Act
            items.Add(char1);
            items.Add(char2);
            items.Add(char3);
            items.Add(char4);
            items.Add(char5);
            items.Add(char6);
            actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
