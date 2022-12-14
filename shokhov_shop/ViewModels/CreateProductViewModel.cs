using shokhov_shop.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace shokhov_shop.ViewModels
{
    public class CreateProductViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name_For_User { get; set; }
        [MinLength(10)]
        public string Description { get; set; }
        [Range(1,999999)]
        public decimal Price { get; set; }
        public People People { get; set; }
        public int Category_id { get; set; }
        public string Sub_category { get; set; }
        public IFormFile Image { get; set; }
    }
}
