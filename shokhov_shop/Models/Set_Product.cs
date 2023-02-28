namespace shokhov_shop.Models
{
    public class Set_Product
    {
        public int Id { get; set; }
        public int Id_Product { get; set; }
        public string Set_Size { get; set; }
        public Order Order { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
