using System;
using System.Collections.Generic;
using static System.Console;

namespace Lesson9.Bots
{
    abstract class Bot
    {
        public abstract string Name { get; }

        public abstract void Greating();
        public abstract void Bye();
        public abstract void NotUnderstand();
        public abstract void HowAreYou();

        protected void TalkPrompt(string s1 = "ask me", string s2 = "understand")
        {
            while (true)
            {

                Write(s1 + " ");
                ForegroundColor = ConsoleColor.Yellow;
                string answer = this.GetAnswer(ReadLine());
                ForegroundColor = ConsoleColor.White;

                if (answer == default(string))
                {
                    WriteLine(s2);
                    Bot.countOfAnswers++;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine(answer);
                    ForegroundColor = ConsoleColor.White;
                    Bot.countOfAnswers++;
                }
                if (Bot.countOfAnswers == 4) break;
            }
        }
        protected string GetAnswer(string question)
        {

            string answers = "";

            if (this is EngBot)
            {
                answers = BotToAsk[BotType.Eng];
            }
            else if (this is UkrBot)
            {
                answers = BotToAsk[BotType.Ukr];
            }
            else if (this is EngBot)
            {
                answers = BotToAsk[BotType.Ukr];
            }

            var msgArr = answers.Split(';');
            foreach (var item in msgArr)
            {

                var strItem = item.Split('=');
                if ( question != "" && strItem[0].ToLower().Contains(question.ToLower().Trim()))
                {
                    return strItem[1];
                    
                }
                
            }
            
            return default(string);
        }

        // static

        public static int countOfAnswers;
        public static Dictionary<BotType, string> BotToLanguage = new Dictionary<BotType, string>
        {
            [BotType.Eng] = "hello,hi,dude",
            [BotType.Ukr] = "привіт,вітаю,добрий",
            [BotType.Rus] = "привет,здравствуйте,здравствуй"
        };

        public static Dictionary<BotType, string> BotToAsk = new Dictionary<BotType, string>
        {
            [BotType.Eng] = @"weather sky wind sun warm = The weather may be fine tommorow. I gonna play all day long;
sport football tennis bike power = I like sport so much. I am Super Bot !;Johnny Depp and Amber Heard settle divorce =
Amber Heard and Johnny Depp have settled their divorce 
case — the day after it surfaced that the jealous actor 
scrawled the names of men he thought she was sleeping 
with on the walls of their villa in his own blood, 
sources told The Post on Tuesday.",
            [BotType.Ukr] = @"погода небо хмар сонц тепл вітер = Можливо завтра буде гарна погода. Я збираюся гратись цілий день;
спорт футбол теніс вело сильн сила спортсмен = Я дуже люблю займатися спортом. Я - Супер Бот !",
            [BotType.Rus] = @"погода небо хмар солнц тепл ветер = Возможно будет хорошая погода. Буду что то делать;
спорт футбол тенис вело сильн сила спортсмен = Люблю лыжи и валенки.",
        };

        public static Bot GetBot(BotType typeBot)
        {
            switch (typeBot)
            {
                case BotType.Eng:
                    return new EngBot("Jonny");
                case BotType.Ukr:
                    return new UkrBot("Бендерик");
                case BotType.Rus:
                    return new RusBot("Шарик");
                default: throw new Exception("Failed Bot");
            }

        }

        public static BotType CheckTypeBot(string data)
        {
            foreach (var KV in Bot.BotToLanguage)
            {
                string text = KV.Value;
                string[] words = text.Split(',');
                foreach (var word in words)
                {
                    if (word.ToLower().Trim() == data.ToLower().Trim())
                    {
                        return KV.Key;
                    }
                }
            }
            throw new Exception("Error. Unchecked Bot.");
        }
    }
}
