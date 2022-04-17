using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAD_CA_PROJECT_INVEST.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Purchase Price is required")]
        public float PurchasePrice { get; set; }
        
        //navigation properties
        public List<Stock> Stocks { get; set; }
        
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}
