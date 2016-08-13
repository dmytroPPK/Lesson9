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
        public abstract void Notunderstand();
        public abstract void HowAreYou();

        public static Bot GetBot(int typeBot)
        {
            switch ((Bots)typeBot)
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
            throw new NotImplementedException();
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
        }

        public override void Notunderstand()
        {
            throw new NotImplementedException();
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
            WriteLine("How are you, my new friend?");
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
        }

        public override void Notunderstand()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override void Greating()
        {
            string msg = "Привет. Меня звать {0}";
            WriteLine(msg,Name);
            Write("А тебя?");
            ReadLine();
            WriteLine("Приятно познакомиться.");
        }

        public override void HowAreYou()
        {
            WriteLine("Как твои делишки?");
        }

        public override void Notunderstand()
        {
            throw new NotImplementedException();
        }
    }
    enum Bots
    {
        Eng=1,
        Ukr,
        Rus
    }
}
