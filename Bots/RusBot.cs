using static System.Console;
using System;
namespace Lesson9.Bots
{
    sealed class RusBot : Bot
    {

        private string _name;

        public override string Name
        {
            get
            {
                return _name;
            }
        }
        public RusBot(string name)
        {
            this._name = name;
        }

        public override void Bye()
        {
            WriteLine("\n\tЧто то я устал. Ладно давай  до встречи");
        }

        public override void Greating()
        {
            string msg = "Привет. Меня звать {0}";
            WriteLine(msg, Name);
            Write("А тебя?  ");
            ForegroundColor = ConsoleColor.Yellow;
            ReadLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Приятно познакомиться.");

        }

        public override void HowAreYou()
        {
            Write("Как твои делишки?  ");
            ForegroundColor = ConsoleColor.Yellow;
            ReadLine();
            ForegroundColor = ConsoleColor.White;
        }

        public override void NotUnderstand()
        {
            this.TalkPrompt(s1: "Спроси меня", s2: "Не могу понять что ты хочеш от меня");
        }


            





    }
}



