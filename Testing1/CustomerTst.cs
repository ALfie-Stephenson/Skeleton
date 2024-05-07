using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{


    [TestClass]
    public class TstCustomer
    {

        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of a class we want to create
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }
    }
}
