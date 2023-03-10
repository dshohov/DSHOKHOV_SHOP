namespace shokhov_shop.Models
{
    public class ChatHistory
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
