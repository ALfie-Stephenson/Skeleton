using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{

    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsStaff Customer = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }
    }
}