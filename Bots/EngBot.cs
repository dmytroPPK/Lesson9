using static System.Console;
using System;
namespace Lesson9.Bots
{
    sealed class EngBot : Bot
    {
        private string _name;

        public override string Name
        {
            get
            {
                return _name;
            }
        }

        public EngBot(string name)
        {
            this._name = name;

        }

        public override void Bye()
        {
            WriteLine("\n\tI am tired. See you soon");

        }

        public override void Greating()
        {
            string msg = "Hello. My name is {0}";
            WriteLine(msg, Name);
            Write("And You?  ");
            ForegroundColor = ConsoleColor.Yellow;
            ReadLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Nice to meet you.");

        }

        public override void HowAreYou()
        {
            Write("How are you, my new friend?  ");
            ForegroundColor = ConsoleColor.Yellow;
            ReadLine();
            ForegroundColor = ConsoleColor.White;

        }

        public override void NotUnderstand()
        {
            this.TalkPrompt(s1: "Ask me anything:", s2: "Sorry. I don't understand you");
        }
            
    }
}
