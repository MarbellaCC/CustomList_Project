using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;

namespace OverloadMinusMethodTests
{
    [TestClass]
    public class OverloadMinusMethodTest
    {
        [TestMethod]
        public void OverloadMinusOperator_RemoveOneItem_CheckCountOfNewList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result;
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int expected = 2;
            int actual;

            //Act
            items.Add(num1);
            items.Add(num2);
            items.Add(num3);
            items2.Add(num3);
            items2.Add(num4);
            items2.Add(num5);
            result = items - items2;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_RemoveItems_CheckCountOfNewList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result;
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int expected = 2;
            int actual;

            //Act
            items.Add(num1);
            items.Add(num2);
            items.Add(num3);
            items.Add(num4);
            items2.Add(num3);
            items2.Add(num4);
            items2.Add(num5);
            result = items - items2;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_RemoveStringInList_CheckAtIndex1()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            CustomList<string> items2 = new CustomList<string>();
            CustomList<string> result;
            string color1 = "azure";
            string color2 = "royal blue";
            string expected = "turquoise";
            string color4 = "periwinkle";
            string actual;

            //Act
            items.Add(color1);
            items.Add(color2);
            items.Add(expected);
            items2.Add(color2);
            items2.Add(color4);
            result = items - items2;
            actual = result[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_RemoveNothiingFromIntList_CheckCount()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result;
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int expected = 3;
            int actual;

            //Act
            items.Add(num1);
            items.Add(num2);
            items.Add(num3);
            items2.Add(num4);
            items2.Add(num5);
            items2.Add(num6);
            result = items - items2;
            actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_RemoveEverythingFromIntList_CheckIndex0()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result;
            int num1 = 1;
            int expected = 0;
            int actual;

            //Act
            items.Add(num1);
            items2.Add(num1);
            result = items - items2;
            actual = result[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
