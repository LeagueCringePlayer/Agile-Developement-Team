using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        string ShippingAdress = "Dmu";
        string PaymentMethod = "visa";
        string Order_Arrival = "true";
        string OrderDate = DateTime.Now.ToShortDateString(); 
        [TestMethod]
        public void InstanceOk()
        {
            //create the instance 
            clsOrder AnOrder = new clsOrder();
            // test the existence 
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderArrival()
        {
            clsOrder AnOrder = new clsOrder(); 
            Boolean TestData = true;
            AnOrder.Order_Arrival = TestData;
            Assert.AreEqual(AnOrder.Order_Arrival,TestData);
        }
        [TestMethod]
        public void DateOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void ShippingAdressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "2 Boulevard Street";
            //assign the data to the property
            AnOrder.ShippingAdress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAdress, TestData);
        }
        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Master Card";
            //assign the data to the property
            AnOrder.PaymentMethod = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }
        
   
        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StockID, TestData);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an istance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check for the CustomerId
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK,"Order id not found");
        }
        [TestMethod]
        public void TestShippingAdressIsFound()
        {
            clsOrder Anorder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Found = Anorder.Find(1);  // Changed from 21 to 8
            if (Anorder.ShippingAdress != "DMU Road") { OK = false; }
            Assert.IsTrue(OK );
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrder Anorder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = Anorder.Valid(this.ShippingAdress,this.PaymentMethod, this.OrderDate);
            // Test to see that the result is correct
            Assert.AreEqual( Error, "");
        }
        [TestMethod]
        public void TestArrivalFound()
        {
            //create an istance of the class we want to create
            clsOrder Anorder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = Anorder.Find(OrderID);
            //check for the Active
            if (Anorder.Order_Arrival!= true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

    }
}
