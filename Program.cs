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
        static void Main(string[] args)
        {

            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Green;
            Bot.GetBot(2).Greating();
            // Delayhf
            ReadKey();
        }
    }
}
