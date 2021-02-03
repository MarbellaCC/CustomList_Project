using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;

namespace OverloadPlusMethodTests
{
    [TestClass]
    public class OverloadPlusMethodTest
    {
        [TestMethod]
        public void OverloadPlusOperator_AddTwoStringLists_CheckCount()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            CustomList<string> items2 = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();
            string color1 = "powder blue";
            string color2 = "ice blue";
            int expected = 2;
            int actual;

            //Act
            items.Add(color1);
            items2.Add(color2);
            result = items + items2;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoIntLists_CheckAtIndex0()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int expected = 1;
            int num2 = 2;
            int actual;

            //Act
            items.Add(expected);
            items2.Add(num2);
            result = items + items2;
            actual = result[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoIntLists_CheckAtIndex2()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int expected = 3;
            int num4 = 4;
            int actual;

            //Act
            items.Add(num1);
            items.Add(num2);
            items2.Add(expected);
            items2.Add(num4);
            result = items + items2;
            actual = result[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoEmptyIntLists_CheckCount()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            result = items + items2;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddEmptyListToIntList_CheckCount()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int num1 = 10;
            int num2 = 20;
            int expected = 2;
            int actual;

            //Act
            items.Add(num1);
            items.Add(num2);
            result = items + items2;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
