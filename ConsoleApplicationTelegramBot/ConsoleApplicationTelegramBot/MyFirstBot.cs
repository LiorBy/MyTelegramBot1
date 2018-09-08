using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ConsoleApplicationTelegramBot
{
    class MyFirstBot
    {
        private static readonly TelegramBotClient m_Bot = 
            new TelegramBotClient("647698451:AAEjsJ-U_otsl80fT5UyXEENPQ7sEqQuErw");

        public void ReceivingMessage()
        {
            m_Bot.OnMessage += M_Bot_OnMessage;
            m_Bot.OnMessageEdited += M_Bot_OnMessage;
            m_Bot.StartReceiving();
            Console.ReadLine();
            m_Bot.StopReceiving();
            
        }

        private void M_Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
           if(e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (e.Message.Text == "How r u?")
                {
                    m_Bot.SendTextMessageAsync(e.Message.Chat.Id, "I'm goood!" + e.Message.Chat.Username);
                }
                else
                {
                    m_Bot.SendTextMessageAsync(e.Message.Chat.Id, "I dont know");
                }
            }
        }
    }
}
