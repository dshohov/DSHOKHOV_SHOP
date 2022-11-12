using shokhov_shop.Data.Enum;

namespace shokhov_shop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name_For_User { get; set; }
        public string Description { get; set; }
        public People People { get; set; }
        public string Image { get; set; }
    }
}
