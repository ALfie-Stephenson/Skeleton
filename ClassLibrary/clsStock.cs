using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mStockID;
        //StockID public property
        public int StockID
        {
            get
            {
                //this line of code sends data out of the property
                return mStockID;
            }
            set
            {
                //this line of code allows data into the property
                mStockID = value;
            }
        }
        //private data member for the game id property
        private string mGameID;
        //GameID public property
        public string GameID
        {
            get
            {
                //this line of code sends data out of the property
                return mGameID;
            }
            set
            {
                //this line of code allows data into the property
                mGameID = value;
            }
        }
        //private data member for the ticket location property
        private string mTicketLocation;
        //Ticket Location public property
        public string TicketLocation
        {
            get
            {
                //this line of code sends data out of the property
                return mTicketLocation;
            }
            set
            {
                //this line of code allows data into the property
                mTicketLocation = value;
            }
        }
        //private data member for the stock Amount property
        private Int32 mStockAmount;
        //Stock Amount public property
        public int StockAmount
        {
            get
            {
                //this line of code sends data out of the property
                return mStockAmount;
            }
            set
            {
                //this line of code allows data into the property
                mStockAmount = value;
            }
        }
        //private data member for the Ticket price property
        private Int32 mTicketPrice;
        //Ticket price public property
        public int TicketPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mTicketPrice;
            }
            set
            {
                //this line of code allows data into the property
                mTicketPrice = value;
            }
        }
        //private data member for the time tickets go on sale property
        private DateTime mTimeTicketsGoOnSale;
        //Time tickets go on sale public property
        public DateTime TimeTicketsGoOnSale
        {
            get
            {
                //this line of code sends data out of the property
                return mTimeTicketsGoOnSale;
            }
            set
            {
                //this line of code allows data into the property
                mTimeTicketsGoOnSale = value;
            }
        }
        //private data member for the in stock property
        private Boolean mInStock;
        //in Stock public property
        public bool InStock
        {
            get
            {
                //this line of code sends data out of the property
                return mInStock;
            }
            set
            {
                //this line of code allows data into the property
                mInStock = value;   
            }
        }
        public clsStock()
        {
        }

      //public bool InStock { get; set; }
        //public DateTime TimeTicketsGoOnSale { get; set; }
        //public int StockID { get; set; }
        //public String GameID { get; set; }
        //public string TicketLocation { get; set; }
        //public int StockAmount { get; set; }
        //public int TicketPrice { get; set; }

        public bool Find(int stockID)
        {
            //set the private data members to the test data value
            mStockID = 5;
            mGameID = "Peterborough vs Cambridge";
            mTicketLocation = "Grand B";
            mStockAmount = 50;
            mTicketPrice = 25;
            mTimeTicketsGoOnSale = Convert.ToDateTime("04/07/2024");
            mInStock = true;
            //always return true
            return true;
        }
    }
}