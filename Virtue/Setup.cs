using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtue
{
    public static class Setup
    {
        public static void FirstTimeSetup()
        {
            // TODO: Consider refactoring
            // TODO: Alternate locales
            var config = new Configuration();

            Console.WriteLine("Welcome to Virtue. Let's get started.");
            Console.WriteLine("We need a GitHub account to work with. Virtue is strongly GitHub-oriented.");
            Console.WriteLine("It is suggested that you create a seperate account for Virtue than your own.");
            Console.Write("Username: "); config.GitHubUsername = Console.ReadLine();
            Console.Write("Password: "); config.GitHubPassword = ReadPassword();
        }

        private static string ReadPassword()
        {
            ConsoleKeyInfo key;
            string password = "";
            do
            {
                key = Console.ReadKey(true);
                if (!char.IsControl(key.KeyChar))
                    password += key.KeyChar;
                if (key.Key == ConsoleKey.Backspace)
                    password = password.Remove(password.Length - 1);
            } while (key.Key != ConsoleKey.Enter);
            return password;
        }
    }
}
