using shokhov_shop.Models;

namespace shokhov_shop.Interfaces
{
    public interface IChatHistoryRepository
    {
        List<ChatHistory> GetChatHistories();
        ChatHistory GetMessage(int chatId);
        bool Add(ChatHistory chatHistory);
        bool Delete(ChatHistory chatHistory);   
        bool Save();
    }
}
