using Octokit;
using System;

namespace Nextcom.Integrations.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = GetCredentials();
            var searchClient = new SearchClient;
        }
            private static Credentials GetCredentials()
            {
                Prettify.WriteLine("Enter username: ", ConsoleColor.Magenta);
                Prettify.Write("> ", ConsoleColor.DarkCyan);
                Console.ForegroundColor = ConsoleColor.Cyan;
                string uName = Console.ReadLine();

                Prettify.WriteLine("Enter password: ", ConsoleColor.Magenta);
                Prettify.Write("> ", ConsoleColor.DarkCyan);
                Console.ForegroundColor = ConsoleColor.Cyan;
                string pw = Console.ReadLine();

                var creds = new Credentials(uName, pw);
                return creds;
            }
    }
}
