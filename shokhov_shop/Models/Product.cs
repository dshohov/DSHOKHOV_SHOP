using shokhov_shop.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace shokhov_shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name_For_User { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public People People { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public int Category_id { get; set; }
        public string Sub_category { get; set; }
        public string Sizes { get; set; }
        

    }
}
