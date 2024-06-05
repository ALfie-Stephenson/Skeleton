using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Testing4
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //public property for the address list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
//constructor for the class
        public clsOrderCollection()
        {
            //create the items of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderColour = "Red";
            TestItem.Price = "450";
            //add the test item to the test list
            mOrderList.Add(TestItem);
            //re Intitialise the object for some new data
            TestItem = new clsOrder();
            //set its properties
            TestItem.Stock = true;
            TestItem.OrderId = 1;
            TestItem.OrderSummary = "Standard E ticket Row A 1-3";
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderColour = "Red";
            TestItem.Price = "450";
        }
        //public List<clsOrder> OrderList { get; internal set; }
        //public int Count { get; internal set; }
        public clsOrder ThisOrder { get;  set; }
    }

}