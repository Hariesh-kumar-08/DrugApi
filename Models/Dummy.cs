using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrugApi.Models
{
    public class Dummy
    {
        [Key]
        public int BuyerId { get; set; }

        
        public string Name { get; set; }    

        public string location { get; set; }

        public string PhoneNumber { get; set; }
        //public string Email;

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Products? Products { get; set; }


    }
}
