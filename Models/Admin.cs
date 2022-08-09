using System.ComponentModel.DataAnnotations;

namespace DrugApi.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; } 
        public string Name { get; set; }
            
        public string password { get; set; }
    }
}
