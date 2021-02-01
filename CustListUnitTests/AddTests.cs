using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            CustomList<string> items = new CustomList<string>();
            string color = "periwinkle";
            int actual;
            int expected = 1;

            //Act
            items.Add(color);
            actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_ChekAtIndex0()
        {
            //Arange
            CustomList<string> items = new CustomList<string>();
            string expected = "periwinkel";
            string actual;

            //Act
            items.Add(expected);
            actual = items[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    
        [TestMethod]
        public void AddItemsToCustomList_CheckForItemAtIndex3()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            string color1 = "azure";
            string color2 = "royal blue";
            string color3 = "turquoise";
            string color4 = "periwinkle";
            string expected = "periwinkle";
            string actual;

            //Act
            items.Add(color1);
            items.Add(color2);
            items.Add(color3);
            items.Add(color4);

            actual = items[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckIntCanBeAdded()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int myNumber = 24;
            
            int expected = 1;
            int actual;

            //Act
            items.Add(myNumber);
            actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemToCustomList_CheckIntAtIndex0()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int expected = 24;
            int actual;

            //Act
            items.Add(expected);
            actual = items[0];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void AddItemsToCustomList_CheckNewCapacity()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
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
            items.Add(color1);
            items.Add(color2);
            items.Add(color3);
            items.Add(color4);//[azure, royal blue, turquoise, periwinkle]
            items.Add(color5);//[azure, royal blue, turquoise, periwinkle, teal, null, null, null]
            items.Add(color6);//[azure, royal blue, turquoise, periwinkle, teal, evergreen, null, null]
            items.Add(color7);
            
            actual = items.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItemsToCustomList_CheckToSeeIfValuesFromOriginalListWereCopiedOver_ZeroIndexIsTheSameAsItWasBefore()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
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
            items.Add(color1);
            items.Add(color2);
            items.Add(color3);
            items.Add(color4);
            items.Add(color5);
            items.Add(color6);
            items.Add(color7);

            actual = items[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
