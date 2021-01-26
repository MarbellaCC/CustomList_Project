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
            CustomList<string> list = new CustomList<string>();
            int num1 = 24;
            string expected = "24";
            string actual;

            //Act
            list.Add(num1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ChangeDoubleToStringTest_CheckCount()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            double num1 = 24.4;
            int expected = 1;
            int actual;

            //Act
            list.Add(num1);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
