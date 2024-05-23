using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.StockId = 1;
            TestItem.ItemName = "TestName";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.ArrivedOn = DateTime.Now;
            TestStock.StockId = 1;
            TestStock.ItemName = "TestName";
            TestStock.Available = true;
            TestStock.Price = 1000;
            TestStock.Quantity = 10;
            TestStock.SupplierId = 1;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create test data
            //needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.StockId = 1;
            TestItem.ItemName = "TestName";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.ItemName = "TestName";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key to the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        



    }
}
