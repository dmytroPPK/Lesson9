using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson9.Bots;
using static System.Console;

namespace Lesson9
{
    class Program
    {
        private static bool _exit = false;

        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            InputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.White;

            Bot bot = null;
            while (!_exit)
            {
                Prompt(ReadLine(), bot);
            }
            
            // Delay
            ReadKey();
        }
        private static void Prompt(string strValue, Bot bot)
        {
            
            try
            {
                if (bot == null)
                {
                    BotType botType = Bot.CheckTypeBot(strValue);
                    Clear();
                    bot = Bot.GetBot(botType);
                    
                }

                bot.Greating();
                bot.HowAreYou();
                bot.NotUnderstand();
                bot.Bye();
                WriteLine("\tBye");
                _exit = true;

            }
            catch(Exception ex)
            {
                
                WriteLine("Don't understand!");
                return;
            }

        }
    }
}



 
  
