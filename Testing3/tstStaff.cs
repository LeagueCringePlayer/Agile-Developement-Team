using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsSaff Astaff = new clsSaff();
            //test to see that it exists
            Assert.IsNotNull(Astaff);
        }
    }
}
