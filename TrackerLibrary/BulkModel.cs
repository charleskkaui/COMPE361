using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class BulkModel
    {
        public string Bulk_ID { get; set; }

        public string Associated_Department { get; set; }

        public int Quantity { get; set; }

        public decimal Buy_Bulk_Price { get; set; }

        public decimal Sell_Price_Per_Unit { get; set; }

        public List<ProductModel> Products_In_Bulk { get; set; }

        public int Received_Month { get; set; }

        public int Received_Day { get; set; }

        public int Received_Year { get; set; }

        public  int Expire_Month { get; set; }

        public int Expire_Day { get; set; }

        public int Expire_Year { get; set; }

    }
}
