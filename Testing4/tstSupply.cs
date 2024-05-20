using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupply
    {
        /*************************INSTANCE OF THE CLASS TEST**************************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //test to see that it exists
            Assert.IsNotNull(ASupply);
        }
        /*************************PROPERTY OK TESTS***********************************/

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
            ASupply.SupplyID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.SupplyID, TestData);
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

        /*************************FIND METHOD TEST**********************************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /*************************PROPERTY DATA TEST FOR SUPPLY ID*******************************/

        [TestMethod]
        public void TestSupplyIDFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the Supply ID
            if (ASupply.SupplyID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR SUPPLIER CONTACT*******************************/

        [TestMethod]
        public void TestSupplierContactFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assime it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the Supplier Contact property
            if (ASupply.SupplierContact != "p1122334@my365.dmu.ac.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR PRICE OF RESOURCE*******************************/

        [TestMethod]
        public void TestPriceOfResourceFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found= ASupply.Find(SupplyID);
            //check the Price Of Resource property
            if (ASupply.PriceOfResource != Convert.ToDouble(1322.15))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR DATE REQUESTED*******************************/

        [TestMethod]
        public void TestDateRequestedFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the Date Requested property
            if (ASupply.DateRequested != Convert.ToDateTime("10/03/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR AVAILABILITY OF SUPPLIER*******************************/

        [TestMethod]
        public void TestAvailabilityOfSupplierFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method 
            Found = ASupply.Find(SupplyID);
            //check the Availability Of Supplier property
            if (ASupply.AvailabilityOfSupplier != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR TO BE DELIVERED BY*******************************/

        [TestMethod]
        public void TestToBeDeliveredByFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the To Be Delivered By property
            if (ASupply.ToBeDeliveredBy != Convert.ToDateTime("15/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
