using shokhov_shop.Data.Enum;

namespace shokhov_shop.Models
{
    public class Sub_Catedory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
        public People People { get; set; }
    }
}
