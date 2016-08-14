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
            ForegroundColor = ConsoleColor.Green;
            
            while (!_exit)
            {
                Prompt(ReadLine());
            }
            
            // Delay
            ReadKey();
        }
        private static void Prompt(string strValue)
        {
            try
            {
                
                if (Bot.CurrentBot == null)
                {
                    Bots.Bots botType = CheckTypeBot(strValue);
                    Clear();
                    Bot.CurrentBot = Bot.GetBot(botType);
                }

                Bot.CurrentBot.Greating();
                Bot.CurrentBot.HowAreYou();
                Bot.CurrentBot.NotUnderstand();
                Bot.CurrentBot.Bye();
                WriteLine("Bye");
                _exit = true;
                
            }
            catch(Exception ex)
            {
                
                WriteLine("Don't understand!");
                return;
            }

        }
        private static Bots.Bots CheckTypeBot(string data)
        {
            foreach (var KV in Bot.BotToLanguage)
            {
                string text = KV.Value;
                string[] words = text.Split(',');
                foreach (var word in words)
                {
                    if (word == data.ToLower().Trim())
                    {
                        return KV.Key;
                    }
                }  
            }
            throw new Exception("Error. Unchecked Bot.");
        }






    }
}



 
   /*
    Dict <string,Enum>{
        ["ukr"]=Enum.Ukr,
        ......
    
    };
     
     
     */
