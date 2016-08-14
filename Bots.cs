using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson9.Bots
{
    abstract class Bot
    {
        //private static List<Bot> _items = new List<Bot>();
        //public static List<Bot> Items { get { return _items; } }

        public abstract string Name { get; }

        public abstract void Greating();
        public abstract void Bye();
        public abstract void NotUnderstand();
        public abstract void HowAreYou();

        // static
        public static Bot CurrentBot;
        public static Dictionary<Bots, string> BotToLanguage = new Dictionary<Bots, string>
        {
            [Bots.Eng] =  "hello,hi,dude" ,
            [Bots.Ukr] = "привіт,вітаю,добрий",
            [Bots.Rus] = "привет,здравствуйте,здравствуй"
        };

        public static Bot GetBot(Bots typeBot)
        {
            switch (typeBot)
            {
                case Bots.Eng:
                    return new EngBot("Jonny");
                case Bots.Ukr:
                    return new UkrBot("Бендерик");
                case Bots.Rus:
                    return new RusBot("Шарик");
                default: throw new Exception("Failed Bot");
            }
            
        }
    }
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
            WriteLine("Я втомився. До зустрічі");
        }

        public override void Greating()
        {
            string msg = "Привіт. Мене звати {0}";
            WriteLine(msg, Name);
            WriteLine("А тебе ?");
            ReadLine();
            WriteLine("Приємно познайомитися.");
            
        }

        public override void HowAreYou()
        {
            WriteLine("Як твої справи?");
            ReadLine();
            
        }

        public override void NotUnderstand()
        {
            WriteLine("Запитай мене: ");
            ReadLine();
            WriteLine("Вибач. Але я не розумію тебе");
        }
    }
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
            WriteLine("I am tired. See you soon");

        }

        public override void Greating()
        {
            string msg = "Hello. My name is {0}";
            WriteLine(msg,Name);
            WriteLine("And You?");
            ReadLine();
            WriteLine("Nice to meet you.");
            
        }

        public override void HowAreYou()
        {
            WriteLine("How are you, my new friend?");
            ReadLine();
            
        }

        public override void NotUnderstand()
        {
            WriteLine("Ask me anything: ");
            ReadLine();
            WriteLine("Sorry. I don't understand you. ");

        }
    }
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
            WriteLine("Что то я устал. Ладно давай  до встречи");
        }

        public override void Greating()
        {
            string msg = "Привет. Меня звать {0}";
            WriteLine(msg,Name);
            WriteLine("А тебя?");
            ReadLine();
            WriteLine("Приятно познакомиться.");
            
        }

        public override void HowAreYou()
        {
            WriteLine("Как твои делишки?");
            ReadLine();
        }

        public override void NotUnderstand()
        {
            WriteLine("Спроси меня: ");
            ReadLine();
            WriteLine("Не могу понять что ты хочеш от меня");
        }
    }
    enum Bots
    {
        Eng=1,
        Ukr,
        Rus
    }
}
