using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrugApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }

       // public string productName { get; set; }

        public int qty { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Products? Products { get; set; }
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Users? Users { get; set; }

        [NotMapped]
        public string? ProductName { get; set; }

        [NotMapped]
        public int? Price { get; set; }





    }
}
