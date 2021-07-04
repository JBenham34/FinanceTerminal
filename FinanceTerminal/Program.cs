using System;
using FinanceTerminal.Securities;


namespace FinanceTerminal
{
    static class Program
    {
        static ISecurity currentSecurity;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                PrintPrompt();
                HandlePrompt();
            }
        }

        private static void PrintPrompt()
        {
            Console.Write(currentSecurity.Symbol);
            Console.Write('>');
        }

        private static void HandlePrompt()
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            if (tokens.Length == 1)
                // User is inputting a single security / command
            {

            }
            else if (tokens.Length == 2)
                // User is inputting a security and command
            {

            }
            else
                // User has malformed command
            {

            }
        }
    }
}
