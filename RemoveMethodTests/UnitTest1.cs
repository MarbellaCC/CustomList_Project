using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;

namespace RemoveMethodTests
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void RemoveItemFromCustomList_CheckCountEquals()
        {
            //Arrange
            CustomList list = new CustomList();
            string color1 = "periwinkle";
            string color2 = "azure";
            int actual;
            int expected = 1;

            //Act
            list.Add(color1, color2);
            list.Remove(color2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]
        public void RemoveItemFromCustomList_CheckAtIndex0()
        {
            //Arrange
            CustomList list = new CustomList();
            string color = "periwinkle";
            string expected = null;
            string actual;

            //Act
            list.Add(expected);
            list.Remove(expected);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItemFromCustomList_CheckAtIndex1()
        {
            //Arrange
            CustomList list = new CustomList();
            string color1 = "azure";
            string color2 = "royal blue";
            string expected = "turquoise";
            string actual;

            //Act
            list.Add(color1, color2, expected);
            list.Remove(color2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void RemoveIntItemFromCustomList_CheckCount()
        {
            //Arrange
            CustomList list = new CustomList();
            int num1 = 32;
            int num2 = 99;
            int expected = 1;
            int actual;

            //Act
            list.Add(num1, num2);
            list.Remove(num2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveIntItemFromCustomList_CheckAtIndex0()
        {
            //Arrange
            CustomList list = new CustomList();
            int num1 = 32;
            int expected = 99;
            int actual;

            //Act
            list.Add(num1, expected);
            list.Remove(num1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
