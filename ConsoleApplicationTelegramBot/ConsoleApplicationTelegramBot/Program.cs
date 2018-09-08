using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.Bot;
namespace ConsoleApplicationTelegramBot
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstBot bot = new MyFirstBot();
            bot.ReceivingMessage();
        }
    }
}
