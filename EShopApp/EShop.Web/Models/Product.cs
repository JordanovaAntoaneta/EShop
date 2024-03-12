using System.ComponentModel.DataAnnotations;

namespace EShop.Web.Models
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
    }
}
