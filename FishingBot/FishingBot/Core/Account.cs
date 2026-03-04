using Telegram.Bot;
using Telegram.Bot.Types;
using FishingBot.Data;
using FishingBot.Utils;

namespace FishingBot.Core
{
    public class Account
    {
        /*public Inventory inventory = new();
        private int level = 1;

        public async Task ShowAccountStats(ITelegramBotClient botClient, Update update)
        {
            string? userName = update.Message?.From?.FirstName + update.Message?.From?.LastName;
            string? userId = update.Message?.From?.Username;

            if (userName != null)
            {
                string accountInfo = $"Аккаунт: {userName}\n" +
                                     $"Айди: @{userId}\n" +
                                     $"Уровень: {level}\n";

                await botClient.SendMessage(Tools.GetChatId(update), accountInfo);
            }
        }*/
    }
}
