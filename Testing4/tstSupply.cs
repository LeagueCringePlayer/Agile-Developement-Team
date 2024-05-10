using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupply
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //test to see that it exists
            Assert.IsNotNull(ASupply);
        }

        [TestMethod]
        public void AvailabilityOfSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASupply.AvailabilityOfSupplier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.AvailabilityOfSupplier, TestData);
        }
        [TestMethod]
        public void DateRequestedPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASupply.DateRequested = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.DateRequested, TestData);
        }
        [TestMethod]
        public void ToBeDeliveredByPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASupply.ToBeDeliveredBy = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.ToBeDeliveredBy, TestData);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupply.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.SupplierID, TestData);
        }
        [TestMethod]
        public void SupplierContactPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            string TestData = "p2709563@my365.dmu.ac.uk";
            //assign the data to the property
            ASupply.SupplierContact = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.SupplierContact, TestData);
        }
        [TestMethod]
        public void PriceOfResourcePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            double TestData = 1699.99;
            //assign the data to the property
            ASupply.PriceOfResource = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.PriceOfResource, TestData);
        }
    }
}
