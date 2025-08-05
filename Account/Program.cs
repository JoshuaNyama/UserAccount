using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        // Shared dictionary to store account info
        static Dictionary<string, string> accounts = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome__");
            Console.WriteLine("(1) Create account" +
                "\n(2) Sign in");

            Console.Write("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    SignIn();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            Console.ReadLine();
        }

        static void CreateAccount()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Create a password: ");
                string password = Console.ReadLine();

                Console.Write("Confirm your password: ");
                string confirmPassword = Console.ReadLine();

                if (password != confirmPassword)
                {
                    Console.WriteLine("Passwords do not match. Try again.\n");
                    continue;
                }

                Console.Write("Enter yer age (18+): ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    Console.WriteLine("you aren't of age yet.");
                    break;
                }

                if (!accounts.ContainsKey(name))
                {
                    accounts.Add(name, password);
                    Console.WriteLine("Account created successfully! you can now proceed.\n");
                }
                else
                {
                    Console.WriteLine("That username already exists. Try a different one.\n");
                    continue;
                }
                break;
            }
            Console.WriteLine("Enter PRIE0-1 Navigate --03");
        }

        static void SignIn()
        {
            if (accounts.Count == 0)
            {
                // Preloaded accounts if needed
                accounts.Add("Joshua", "Joshua05");
                accounts.Add("Josh", "Josh01");
                accounts.Add("Shadow", "Shadow05");
                accounts.Add("Nova", "Lord");
            }

            bool loggedIn = false;

            while (!loggedIn)
            {
                Console.WriteLine("___Enter account details___");
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (accounts.ContainsKey(username) && accounts[username] == password)
                {
                    Console.WriteLine("Login successful. Welcome, " + username + "!");
                    loggedIn = true;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. Try again.\n");
                }
            }
        }
    }
}
