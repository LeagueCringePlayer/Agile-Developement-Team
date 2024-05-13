using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "John Doe";
            // assign the data to the property
            AStaff.StaffName = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "johndoe@example.com";
            AStaff.StaffEmail = TestData;
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "Manager";
            AStaff.StaffRole = TestData;
            Assert.AreEqual(AStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void DateHiredPropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateHired = TestData;
            Assert.AreEqual(AStaff.DateHired, TestData);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            bool TestData = true;
            AStaff.IsActive = TestData;
            Assert.AreEqual(AStaff.IsActive, TestData);
        }

        [TestMethod]
        public void HourlyRatePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            decimal TestData = 15.75m;
            AStaff.HourlyRate = TestData;
            Assert.AreEqual(AStaff.HourlyRate, TestData);
        }
    }
}
