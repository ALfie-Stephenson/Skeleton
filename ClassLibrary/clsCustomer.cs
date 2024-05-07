using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool AccountActivity { get; set; }
        public DateTime CustomerJoinDate { get; set; }
        public DateTime CustomerExpiryDate { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerNo { get; set; }
        public long CustomerCardNo { get; set; }
        public int CustomerCVC { get; set; }
    }
}