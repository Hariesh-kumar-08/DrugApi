using System.ComponentModel.DataAnnotations;

namespace DrugApi.Models
{
    public class Users
    {

        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
