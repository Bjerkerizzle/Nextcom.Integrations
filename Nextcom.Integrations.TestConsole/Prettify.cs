using System;
using System.Collections.Generic;
using System.Text;

namespace Nextcom.Integrations.TestConsole
{
    class Prettify
    {
        public static void WriteLine(string text, ConsoleColor cc)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(text);
        }

        public static void Write(string text, ConsoleColor cc)
        {
            Console.ForegroundColor = cc;
            Console.Write(text);
        }
    }
}
