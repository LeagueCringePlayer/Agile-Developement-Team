using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderCollection AllOrderAdress = new clsOrderCollection();
            Assert.IsNotNull(AllOrderAdress);
        }
    }
}
