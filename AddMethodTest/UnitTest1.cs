﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Custom_List;


namespace AddMethodTest
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        public void AddItemToCustomList_ChekCountEquals()
        {
            
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string color = "periwinkle";
            int actual;
            int expected = 1;

            //Act
            list.Add(color);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_ChekAtIndex0()
        {
            //Arange
            CustomList<string> list = new CustomList<string>();
            string expected = "periwinkel";
            string actual;

            //Act
            list.Add(expected);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    
        [TestMethod]
        public void AddItemsToCustomList_CheckForItemAtIndex3()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string color1 = "azure";
            string color2 = "royal blue";
            string color3 = "turquoise";
            string color4 = "periwinkle";
            string expected = "periwinkle";
            string actual;

            //Act
            list.Add(color1);
            list.Add(color2);
            list.Add(color3);
            list.Add(color4);

            actual = list[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckIntCanBeAdded()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int myNumber = 24;
            
            int expected = 1;
            int actual;

            //Act
            list.Add(myNumber);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckIntAtIndex0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 24;
            int actual;

            //Act
            list.Add(expected);
            actual = list[0];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void AddItemsToCustomList_CheckNewCapacity()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string color1 = "azure";
            string color2 = "royal blue";
            string color3 = "turquoise";
            string color4 = "periwinkle";
            string color5 = "teal";
            string color6 = "evergreen";
            string color7 = "cerulean";
            
            int expected = 8;
            int actual;
            
            //Act
            list.Add(color1);
            list.Add(color2);
            list.Add(color3);
            list.Add(color4);//[azure, royal blue, turquoise, periwinkle]
            list.Add(color5);//[azure, royal blue, turquoise, periwinkle, teal, null, null, null]
            list.Add(color6);//[azure, royal blue, turquoise, periwinkle, teal, evergreen, null, null]
            list.Add(color7);
            
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemsToCustomList_CheckToSeeIfValuesFromOriginalListWereCopiedOver_ZeroIndexIsTheSameAsItWasBefore()
        {
            //Arrange
            CustomList<string> list = new CustomList<string.();
            string color1 = "azure";
            string color2 = "royal blue";
            string color3 = "turquoise";
            string color4 = "periwinkle";
            string color5 = "teal";
            string color6 = "evergreen";
            string color7 = "cerulean";
            string expected = "azure";
            string actual;

            //Act
            list.Add(color1);
            list.Add(color2);
            list.Add(color3);
            list.Add(color4);
            list.Add(color5);
            list.Add(color6);
            list.Add(color7);

            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
