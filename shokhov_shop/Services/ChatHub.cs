using Microsoft.AspNetCore.SignalR;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;

namespace shokhov_shop.Services
{
    public class ChatHub : Hub
    {
        private readonly IChatHistoryRepository _chatHistoryRepository;

        public ChatHub(IChatHistoryRepository chatHistoryRepository)
        {
            _chatHistoryRepository = chatHistoryRepository;
        }
        public async Task Send(string name, string message)
        {
            var _message = new ChatHistory
            {
                SenderName = name,
                Message = message,
                CreatedDate = DateTime.Now
            };
            _chatHistoryRepository.Add(_message);


            await Clients.All.SendAsync("broadcastMessage", name, message);

        }
        

    }
}
