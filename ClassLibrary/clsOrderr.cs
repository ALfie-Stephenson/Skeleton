using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderNo { get; set; }
        public string OrderSummary { get; set; }
        public string Colour { get; set; }
        public int Price { get; set; }
        public bool Stock { get; set; }
    }
}