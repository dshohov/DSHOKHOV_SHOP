﻿using shokhov_shop.Data;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;

namespace shokhov_shop.Repository
{
    public class ChatHistoryRepository : IChatHistoryRepository
    {
        private readonly ApplicationDbContext context;

        public ChatHistoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Add(ChatHistory chatHistory)
        {
            this.context.Add(chatHistory);
            return Save();
        }

        public List<ChatHistory> GetChatHistories()
        {
            return this.context.ChatHistory
                .OrderByDescending(m => m.CreatedDate)
                .Take(50)
                .ToList();
        }

        public bool Save()
        {
            var saved = this.context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}