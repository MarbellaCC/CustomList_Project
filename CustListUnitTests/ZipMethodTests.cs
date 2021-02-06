using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;

namespace ZipMethodTests
{
    [TestClass]
    public class ZipMethodTests
    {
        [TestMethod]
        public void ZipMethod_JoinIntLists_CheckCount()
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
            int expected = 6;
            int actual;

            //Act
            items.Add(num1);
            items2.Add(num2);
            items.Add(num3);
            items2.Add(num4);
            items.Add(num5);
            items2.Add(num6);
            result = items.Zip(items, items2);
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_JoinStringList_CheckCount()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            CustomList<string> items2 = new CustomList<string>();
            CustomList<string> result;
            string color1 = "azure";
            string color2 = "royal blue";
            string color3 = "turquoise";
            string color4 = "periwinkle";
            int expected = 4;
            int actual;

            //Act
            items.Add(color1);
            items.Add(color2);
            items2.Add(color3);
            items2.Add(color4);
            result = items.Zip(items, items2);
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ZipMethod_JoinIntLists_CheckAtIndex1()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> items2 = new CustomList<int>();
            CustomList<int> result;
            int num1 = 1;
            int expected = 2;
            int num3 = 3;
            int num4 = 4;
            int actual;

            //Act
            items.Add(num1);
            items2.Add(expected);
            items.Add(num3);
            items2.Add(num4);
            result = items.Zip(items, items2);
            actual = result[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ZipMethod_JoinIntListsFirstListShorterThanSecond_CheckAtIndex5()
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
            int expected = 6;
            int actual;

            //Act
            items.Add(num1);
            items2.Add(num2);
            items.Add(num3);
            items2.Add(num4);
            items2.Add(num5);
            items2.Add(num6);
            result = items.Zip(items, items2);
            actual = result[5];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_JoinIntListsSecondListShorter_CheckIndex5()
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
            int expected = 6;
            int actual;

            //Act
            items.Add(num1);
            items2.Add(num2);
            items.Add(num3);
            items2.Add(num4);
            items.Add(num5);
            items.Add(num6);
            result = items.Zip(items, items2);
            actual = result[5];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
