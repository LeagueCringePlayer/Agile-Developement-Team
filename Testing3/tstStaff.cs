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
            AStaff.Name = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
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
            AStaff.Role = TestData;
            Assert.AreEqual(AStaff.Role, TestData);
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
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
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
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 9;  // Changed from 21 to 8
            Found = aStaff.Find(StaffId);
            Assert.IsTrue(Found, "Error: The staff member could not be found.");
        }

        [TestMethod]
        public void TestStaffIdIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 9;  // Changed from 21 to 8
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffId != 9) { OK = false; }  // Changed from 21 to 8
            Assert.IsTrue(OK, "Staff ID not found correctly.");
        }

        [TestMethod]
        public void TestNameIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.Name != "issam") { OK = false; }
            Assert.IsTrue(OK, "Name not found correctly.");
        }

        [TestMethod]
        public void TestRoleIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.Role != "shpping ") { OK = false; }
            Assert.IsTrue(OK, "Role not found correctly.");
        }

        [TestMethod]
        public void TestDateHiredIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.DateHired != Convert.ToDateTime("2020-03-09")) { OK = false; }
            Assert.IsTrue(OK, "Date Hired not found correctly.");
        }

        [TestMethod]
        public void TestActiveIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (!aStaff.Active) { OK = false; }
            Assert.IsTrue(OK, "Active status not found correctly.");
        }

        [TestMethod]
        public void TestHourlyRateIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.HourlyRate != 50.00m) { OK = false; }
            Assert.IsTrue(OK, "Hourly rate not found correctly.");
        }

    }
}
