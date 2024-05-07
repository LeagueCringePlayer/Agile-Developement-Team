using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class to create
            clsStock StockItem = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(StockItem);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create some test data to assign to property
            int TestData = 1;
            //assign test data to property
            StockItem.StockId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.StockId, TestData);
        }

        [TestMethod]
        public void ArrivedOnPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            StockItem.ArrivedOn = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.ArrivedOn, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            string TestData = "GeForce GTX 1660";
            //assign the data to the property
            StockItem.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.ItemName, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            int TestData = 5;
            //assign the data to the property
            StockItem.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Quantity, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            double TestData = 1699.99;
            //assign the data to the property
            StockItem.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            Boolean TestData = true;
            //assign the data to the property
            StockItem.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Available, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            int TestData = 1;
            //assign the data to the property
            StockItem.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.SupplierId, TestData);
        }


    }
}
