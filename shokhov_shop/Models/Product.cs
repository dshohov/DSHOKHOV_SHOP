using shokhov_shop.Data.Enum;

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
        public int Category_id { get; set; }
        public string Sub_category { get; set; }
    }
}
