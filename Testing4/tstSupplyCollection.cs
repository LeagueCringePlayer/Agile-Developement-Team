using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();    
            //test to see that is exists
            Assert.IsNotNull(AllSupplies); 
        }

        [TestMethod]
        public void SupplyListOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupply> TestList = new List<clsSupply>();
            //Add an Item to the list
            //create the item of test data
            clsSupply TestItem = new clsSupply();
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 1009;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;   
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSupplies.SupplyList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.SupplyList, TestList);
        }
        
        [TestMethod]
        public void ThisSupplyPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create some test data to assign to the property
            clsSupply TestSupply = new clsSupply();
            //set the properties of the test object 
            TestSupply.SupplyID = 2;
            TestSupply.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestSupply.PriceOfResource = 1009;
            TestSupply.DateRequested = DateTime.Now;
            TestSupply.AvailabilityOfSupplier = true;
            TestSupply.ToBeDeliveredBy = DateTime.Now;
            //assign the data to the property
            AllSupplies.ThisSupply = TestSupply;
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.ThisSupply, TestSupply);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create some test data to assign to the property
            //the data needs to be a list of objects
            List<clsSupply> TestList = new List<clsSupply>();
            //Add an Item to the list 
            //create the item of the test data
            clsSupply TestItem = new clsSupply();
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 1009;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSupplies.SupplyList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create the item of test data
            clsSupply TestItem = new clsSupply();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p3333333@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 889;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //set ThisSupply to the test data
            AllSupplies.ThisSupply = TestItem;
            //add the record
            PrimaryKey = AllSupplies.Add();
            //set the primary key of the test data
            TestItem.SupplyID = PrimaryKey;
            //find the record
            AllSupplies.ThisSupply.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.ThisSupply, TestItem);
        }
    }
}
