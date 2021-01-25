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
            CustomList list = new CustomList();
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
            CustomList list = new CustomList();
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
            CustomList list = new CustomList();
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

        
        
    }

}
