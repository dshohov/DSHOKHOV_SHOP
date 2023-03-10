using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ChatHistory>> GetChatHistories()
        {
            return await _context.ChatHistory
                .OrderByDescending(m => m.CreatedDate)
                .ToListAsync();
        }

        public async Task<ChatHistory> GetMessage(int chatId)
        {
            return await _context.ChatHistory.Where(i => i.Id == chatId).FirstOrDefaultAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
