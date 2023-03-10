using shokhov_shop.Data.Enum;

namespace shokhov_shop.ViewModels
{
    public class CreateOrEditCategoryViewModel
    {
        public int Id { get; set; }
        public string Name_For_User { get; set; }
        public string Description { get; set; }
        public People People { get; set; }
        public IFormFile Image { get; set; }
        public string? URL { get; set; }
    }
}
