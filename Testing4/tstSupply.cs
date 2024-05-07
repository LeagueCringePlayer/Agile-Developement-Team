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
    }
}
