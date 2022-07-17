using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp
{
    public static class CW
    {
        public static void Color()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Color(string color)
        {
            switch (color.ToLower())
            {
                case "green":
                case "g":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                case "b":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                case "y":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "cyan":
                case "c":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "dark green":
                case "dg":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "dark blue":
                case "db":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "red":
                case "r":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "dark red":
                case "dr":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark yellow":
                case "dy":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "white":
                case "w":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        public static void ConsoleClear()
        {
            Console.Clear();
            PrintDT();
            PrintLB();
        }
        public static void PrintBetaDetails()
        {
            Console.WriteLine("For the purpose of using the beta, this is all faulty money and no transactions actually route through the internet." +
                "\nThis is all locally.");
            Console.WriteLine("Being said, everytime you run this program, you will have to have to make a new account." +
                "\n\n");
        }
        public static void PrintDT()
        {
            Color("dark green");
            Console.WriteLine($"{System.DateTime.Now.AddDays(0)}");
            Color();
        }
        public static void PrintLB()
        {
            Console.WriteLine("=================================");
        }
        public static void PrintWelcomeScreen()
        {
            Color("cyan");
            Console.WriteLine("Welcome to JoseCoBanking! (Beta)" +
            "\n\n");
            Color();
        }
        public static void YN()
        {
            Color("dy");
            Console.WriteLine(" (Y/N)");
        }
        public static void ErrorPrinter(int errorNum)
        {
            Color("red");
            switch(errorNum)
            {
                case 0:
                    Console.WriteLine("The program will now terminate");
                    break;
                case 404:
                    Console.WriteLine("This field cannot be empty, please enter the correct field");
                    break;
                case 405:
                    Console.WriteLine("Incorrect input, please enter the correct field");
                    break;
                default:
                    Console.WriteLine("[THIS ERROR CODE IS UNRECOGNIZABLE. PLEASE CONTACT ADMINISTRATOR TO ADD ERROR CODE]");
                    Console.WriteLine($"[ERROR CODE: {errorNum}]");
                    break;
            }
            Color();
        }
    }
}
