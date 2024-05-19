using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John Doe";
            TestItem.StaffEmail = "john.doe@example.com";
            TestItem.Role = "Manager";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
      
       

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.Name = "John Doe";
            TestStaff.StaffEmail = "john.doe@example.com";
            TestStaff.Role = "Manager";
            TestStaff.DateHired = DateTime.Now.Date;
            TestStaff.HourlyRate = 25.50m;
            TestStaff.Active = true;
            // assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
       
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John marr Doe";
            TestItem.StaffEmail = "john.dvsa.dvsdoe@example.com";
            TestItem.Role = "Managers";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);

            // create another item of test data
            TestItem = new clsStaff();
            // set its properties
            TestItem.StaffId = 2;
            TestItem.Name = "Jane Smith";
            TestItem.StaffEmail = "jane.smith@example.com";
            TestItem.Role = "Assistant";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 20.00m;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }





    }
}
