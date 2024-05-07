using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public bool InStock { get; set; }
        public DateTime TimeTicketsGoOnSale { get; set; }
        public int StockID { get; set; }
        public int GameID { get; set; }
        public string TicketLocation { get; set; }
        public int StockAmount { get; set; }
        public int TicketPrice { get; set; }
    }
}