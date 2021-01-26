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
            CustomList<string> list = new CustomList<string>();
            string color1 = "periwinkle";
            string color2 = "azure";
            int actual;
            int expected = 1;

            //Act
            list.Add(color1);
            list.Add(color2);
            list.Remove(color2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]
        public void RemoveItemFromCustomList_CheckAtIndex0()
        {
            //Test for index out of range?  this has to do with the indexer property that you will create later
            //This does make sense until that happens!

            //Arrange
            CustomList<string> list = new CustomList<string>();
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
            CustomList<string> list = new CustomList<string>();
            string color1 = "azure";
            string color2 = "royal blue";
            string expected = "turquoise";
            string actual;

            //Act
            list.Add(color1);
            list.Add(color2);
            list.Add(expected);

            list.Remove(color2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void RemoveIntItemFromCustomList_CheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int num1 = 32;
            int num2 = 99;
            int expected = 1;
            int actual;

            //Act
            list.Add(num1)
            list.Add(num2);
            list.Remove(num2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveIntItemFromCustomList_CheckAtIndex0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int num1 = 32;
            int expected = 99;
            int actual;

            //Act
            list.Add(num1);
            list.Add(expected);
            list.Remove(num1);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //create a test that tries to remove something that is not in the list.   make sure the count doesn't go down
        [TestMethod]
        public void TryToRemoveItemNotInCutomList_CheckCountStaysTheSame()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string color1 = "turquoise";
            string color2 = "old rose";
            int expected = 1;
            int actual;

            //Act
            list.Add(color1);
            list.Remove(color2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
