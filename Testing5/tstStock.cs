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
            //create an instance of the new class to create
            clsStock StockItem = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(StockItem);
        }
    }
}
