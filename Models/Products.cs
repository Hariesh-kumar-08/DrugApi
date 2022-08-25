using System.ComponentModel.DataAnnotations;


namespace DrugApi.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string? MfdDate { get; set; }

        public string? ExpDate { get; set; }

        public int price { get; set; }

        public int Stock { get; set; }


        public virtual OrderDetail? OrderDetail { get; set; }
        public virtual Dummy? Dummy { get; set; }

        //public virtual ICollection<Dummy>? Dummies{ get; set; }

        //public virtual ICollection<OrderDetail>? OrderDetail { get; set; }



    }
}
