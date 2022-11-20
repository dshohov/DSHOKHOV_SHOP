using shokhov_shop.Data.Enum;

namespace shokhov_shop.ViewModels
{
    public class CreateProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name_For_User { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public People People { get; set; }
        public int Category_id { get; set; }
        public string Category { get; set; }
        public string Sub_category { get; set; }
        public IFormFile Image { get; set; }
    }
}
