using shokhov_shop.Data;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;

namespace shokhov_shop.Repository
{
    public class ChatHistoryRepository : IChatHistoryRepository
    {
        private readonly ApplicationDbContext _context;

        public ChatHistoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(ChatHistory chatHistory)
        {
            _context.Add(chatHistory);
            return Save();
        }

        public bool Delete(ChatHistory chatHistory)
        {
            _context.Remove(chatHistory);
            return Save();
        }

        public List<ChatHistory> GetChatHistories()
        {
            return _context.ChatHistory
                .OrderByDescending(m => m.CreatedDate)
                .ToList();
        }

        public ChatHistory GetMessage(int chatId)
        {
            return _context.ChatHistory.Where(i => i.Id == chatId).FirstOrDefault();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
