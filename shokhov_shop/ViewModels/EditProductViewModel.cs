
using shokhov_shop.Data.Enum;

namespace shokhov_shop.ViewModels
{
    public class EditProductViewModel
    {
        public int Id { get; set; }
        public string Name_For_User { get; set; }
        public string Description { get; set; }
        public People People { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile Image2 { get; set; }
        public IFormFile Image3 { get; set; }
        public IFormFile Image4 { get; set; }
        public IFormFile Image5 { get; set; }
        public string? URL { get; set; }
        public decimal Price { get; set; }
        public int Category_id { get; set; }
        public string Sub_category { get; set; }
    }
}
