using static System.Console;
using System;

namespace Lesson9.Bots
{
    sealed class UkrBot : Bot
    {
        private string _name;

        public override string Name
        {
            get
            {
                return _name;
            }
        }

        public UkrBot(string name)
        {
            this._name = name;
        }
        public override void Bye()
        {
            WriteLine("\n\tЯ втомився. До зустрічі");
        }

        public override void Greating()
        {
            string msg = "Привіт. Мене звати {0}";
            WriteLine(msg, Name);
            Write("А тебе ? ");
            ForegroundColor = ConsoleColor.Yellow;
            ReadLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Приємно познайомитися.");

        }

        public override void HowAreYou()
        {
            Write("Як твої справи? ");
            ForegroundColor = ConsoleColor.Yellow;
            ReadLine();
            ForegroundColor = ConsoleColor.White;
        }

        public override void NotUnderstand()
        {
            this.TalkPrompt(s1: "Запитай мене:", s2: "Вибач. Але я не розумію тебе");
        }
            
    } // end class
}
