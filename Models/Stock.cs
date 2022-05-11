using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EAD_CA_PROJECT_INVEST.Model
{
    public class Stock
    {
        [Key]
        [DisplayName("Stock ID")]
        public int StockID { get; set; }
        [Required(ErrorMessage = "Stock Name is required")]
        [DisplayName("Stock Name")]
        public string StockName { get; set; }
        [Required(ErrorMessage = "Stock Ticker is required")]
        [DisplayName("Stock Ticker ")]
        public string StockTicker { get; set; }
        [Required(ErrorMessage = "Stock Price is required")]
        [DisplayName("Purchase Price (€)")]
        public float StockPrice { get; set; }
        [Required(ErrorMessage = "Sell Price is required")]
        [DisplayName("Sell Price (€)")]
        public float SellPrice { get; set; }
        [Required(ErrorMessage = "Total Shares is required")]
        [DisplayName("Total Shares")]
        public float TotalShares { get; set; }
        [Required(ErrorMessage = "Exchange Name is required")]
        [DisplayName("Exhange Name")]
        public string ExchangeName { get; set; }



        //navigation properties

        public virtual ICollection<Order> Order { get; set; }

        //static async Task GetsAsync
        //{
        //    // Get stock current price using Yahoo Api - Didn't work well

        //        try
        //        {

        //        using (HttpClient httpClient = new HttpClient())
        //        {
        //            httpClient.BaseAddress = new Uri("https://yfapi.net/");
        //            httpClient.DefaultRequestHeaders.Add("X-API-KEY",
        //                "ZFQ4vi02Lh8CgPerjwv6C2ETLvRr6F8i3EIonNXH");
        //            httpClient.DefaultRequestHeaders.Add("accept",
        //                "application/json");

        //            var response = await httpClient.GetAsync(
        //            "/v6/finance/quote?symbols=AAPL");
        //            //"v11/finance/quoteSummary/AAPL?lang=en&region=US&modules=defaultKeyStatistics%2CassetProfile");

        //            var responseBody = await response.Content.ReadAsStringAsync();
        //            if (response.IsSuccessStatusCode)
        //            {

        //                dynamic stockInfos = JObject.Parse(responseBody);
        //                _currentPrice = stockInfos.quoteResponse.result[0].ask;
        //                //Console.WriteLine("The current stock price is: {0} $", currentStockPrice);

        //            }


        //            else
        //            {
        //                Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
        //            }

        //        }
        //    }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
    }
                

}
