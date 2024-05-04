using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class to create
            clsStock StockItem = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(StockItem);
        }
    }
}
