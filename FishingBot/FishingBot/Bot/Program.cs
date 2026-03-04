using FishingBot.Core;
using FishingBot.Data;
using FishingBot.Utils;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FishingBot.Bot
{
    public static class Program
    {
        //private static Account? account;
        //private static bool isCreated;

        private static Dictionary<string, string> command = new()
        {

        };

        private static void Main(string[] args)
        {
            Host bot = new("8755713014:AAFX3SJHTe-pgS4uD-nsVtNe8L6PltFXans");
            bot.Start();
            bot.onMessage += OnMessage;
            Console.ReadKey();
        }

        private static async void OnMessage(ITelegramBotClient botClient, Update update)
        {
            var rand = new Random();
            long chatId = Tools.GetChatId(update);
            int? replyId = update?.Message?.MessageId;

            string? commands = update?.Message?.Text?.ToLower();
            switch (commands)
            {
                case "/start":
                   /* if (isCreated != true)
                        account = new();
                   */
                    await botClient.SendMessage(chatId, $"Вас приветствует бот для рыбалки!\n" +
                        $"Воспользуйтесь командой \"/fish\" что бы начать увлекательную рыбалку!\n" +
                        $"Командой \"/inventory\" можно посмотреть всё что ты наловил за это время.\n" +
                        $"А \"/account\" выведет информацию о аккаунте!\n" +
                        $"Удачи!!!", replyParameters: replyId);
                    break;

                case "/fish":
                    float chance = (float)rand.NextDouble();
                    var fish = FishStorage.Fishing();

                    if (chance < 0.3f)
                    {
                        await botClient.SendMessage(
                            chatId,
                            "🎣 Рыба сорвалась",
                            replyParameters: replyId
                        );
                    }
                    else
                    {
                        await botClient.SendSticker(
                            chatId,
                            fish.fishImage,
                            replyParameters: replyId
                        );

                        await botClient.SendMessage(
                            chatId,
                            $"Клюнуло! Ты поймал {fish.fishName}, весом {fish.fishWeight}кг. В инвентаре теперь: 1 шт.",
                            replyParameters: replyId + 1
                        );
                    }

                    break;

                /*case "/allfish":
                    storage?.Besteari(botClient, update);
                    break;*/
            }
        }
    }
}