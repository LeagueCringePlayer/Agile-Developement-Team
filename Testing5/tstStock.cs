using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class to create
            clsStock StockItem = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(StockItem);
        }

        /******************PROPERTY OK TESTS******************/

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

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock StockItem = new clsStock();
            //create a boolean varaible to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the stockId
            if (StockItem.StockId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArrivedOnFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the arrived on property
            if (StockItem.ArrivedOn != Convert.ToDateTime("12/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the item name property
            if (StockItem.ItemName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the quantity property
            if (StockItem.Quantity != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the price property
            if (StockItem.Price != 1000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the available property
            if (StockItem.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 2;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the supplier id property
            if (StockItem.SupplierId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
