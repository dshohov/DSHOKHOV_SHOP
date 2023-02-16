using shokhov_shop.Models;

namespace shokhov_shop.Interfaces
{
    public interface IChatHistoryRepository
    {
        List<ChatHistory> GetChatHistories();
        bool Add(ChatHistory chatHistory);
        bool Save();
    }
}
