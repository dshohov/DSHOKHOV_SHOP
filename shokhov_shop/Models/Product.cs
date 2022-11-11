namespace shokhov_shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Sub_Catedory SubCatedory { get; set; }
    }
}
