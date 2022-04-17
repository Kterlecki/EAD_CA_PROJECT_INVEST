using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EAD_CA_PROJECT_INVEST.Model
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        //[Required(ErrorMessage = "Stock Name is required")]
        public string StockName { get; set;}
        //[Required(ErrorMessage = "Stock Ticker is required")]
        public string StockTicker { get; set;}
        //[Required(ErrorMessage = "Stock Price is required")]
        //[DisplayName("Price (€)")]
        public float StockPrice { get; set;}
        //[Required(ErrorMessage = "Sell Price is required")]
        //[DisplayName("Price (€)")]
        public float SellPrice { get; set;}
        //[Required(ErrorMessage = "Total Shares is required")]
        public float TotalShares { get; set;}
        //[Required(ErrorMessage = "Exchange Name is required")]
        public string ExchangeName { get; set;}

        //navigation properties

        public int OrderID { get; set;}
        public virtual Order Order { get; set;}

    }
}
