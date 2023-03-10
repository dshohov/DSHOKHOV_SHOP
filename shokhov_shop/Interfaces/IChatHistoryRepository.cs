using shokhov_shop.Models;

namespace shokhov_shop.Interfaces
{
    public interface IChatHistoryRepository
    {
        Task<List<ChatHistory>> GetChatHistories();
        Task<ChatHistory> GetMessage(int chatId);
        bool Add(ChatHistory chatHistory);
        bool Delete(ChatHistory chatHistory);   
        bool Save();
    }
}
