using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrugApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }

     

        public int qty { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Products? Products { get; set; }
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Users? Users { get; set; }

       



    }
}
