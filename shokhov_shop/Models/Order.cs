namespace shokhov_shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Set_Product> Set_Products { get; set; }
        public AppUser User { get; set; }
        public string? Full_Name { get; set; }
        public string? Telefon { get; set; }
        public string? City { get; set; }
        public int? Number_Post { get; set; }
        public bool Is_Approved { get; set; }
        public string? Comment { get; set; }
        public decimal? Total_Price { get; set; }
    }
}
