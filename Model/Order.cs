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
        [ForeignKey("Stock")]
        public Stock Stock { get; set; }
        [ForeignKey("User")]
        public User User { get; set; }

    }
}
