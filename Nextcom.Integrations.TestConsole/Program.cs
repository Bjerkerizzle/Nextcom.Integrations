using Nextcom.Integrations.ThirdParties.Tripletex;
using System;

namespace Nextcom.Integrations.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = GetCredentials();
            var searchClient = new SearchClient(credentials);
            ShowAuthStatus(searchClient);
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
        private static void ShowAuthStatus(SearchClient searchClient)
        {
            if (searchClient.CheckAuthStatus())
            {
                Prettify.WriteLine("Authentication Successful!", ConsoleColor.Green);
            }
            else
            {
                Prettify.WriteLine("Authentication Unsuccessful!", ConsoleColor.Red);
            }
        }
    }
}
