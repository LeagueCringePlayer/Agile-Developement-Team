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
        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // create a Boolean variable to store the results of the validation
            Boolean Found = false;

            // create some test data to use with the method
            Int32 StaffId = 21;  // Assuming 21 is a valid staff ID for your test cases

            // invoke the method
            Found = aStaff.Find(StaffId);

            // test to see if the result is true
            Assert.IsTrue(Found, "Error: The staff member could not be found.");
        }
        [TestMethod]
        public void TestStaffIdIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffId != 21) { OK = false; }
            Assert.IsTrue(OK, "Staff ID not found correctly.");
        }

        [TestMethod]
        public void TestNameIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(21);
            if (aStaff.Name != "John Doe") { OK = false; }
            Assert.IsTrue(OK, "Name not found correctly.");
        }

        [TestMethod]
        public void TestRoleIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(21);
            if (aStaff.Role != "Developer") { OK = false; }
            Assert.IsTrue(OK, "Role not found correctly.");
        }

        [TestMethod]
        public void TestDateHiredIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(21);
            if (aStaff.DateHired != Convert.ToDateTime("2020-01-01")) { OK = false; }
            Assert.IsTrue(OK, "Date Hired not found correctly.");
        }

        [TestMethod]
        public void TestActiveIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(21);
            if (!aStaff.Active) { OK = false; }
            Assert.IsTrue(OK, "Active status not found correctly.");
        }

        [TestMethod]
        public void TestHourlyRateIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(21);
            if (aStaff.HourlyRate != 25.50m) { OK = false; }
            Assert.IsTrue(OK, "Hourly rate not found correctly.");
        }
    }
}
