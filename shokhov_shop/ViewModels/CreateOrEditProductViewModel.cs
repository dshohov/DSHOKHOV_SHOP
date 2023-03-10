
using shokhov_shop.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace shokhov_shop.ViewModels
{
    public class CreateOrEditProductViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name_For_User { get; set; }
        [MinLength(10)]
        public string Description { get; set; }
        public People People { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile Image2 { get; set; }
        public IFormFile Image3 { get; set; }
        public IFormFile Image4 { get; set; }
        public IFormFile Image5 { get; set; }
        public string? URL { get; set; }
        [Range(1, 999999)]
        public decimal Price { get; set; }
        public int Category_id { get; set; }
        public string Sub_category { get; set; }
        public string[] Sizes_Array { get; set; }
    }
}
