using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp
{
    public class Methods
    {
        public static void RunWouldYouLikeToCreateAnAccount()
        {
            bool continueProgram = false;
            do
            {
                Console.Write("Would you like to create an account?");
                CW.YN();
                _ = char.TryParse(Console.ReadLine(), out char continueUserInput);
                CW.Color();
                switch (continueUserInput)
                {
                    case 'Y':
                    case 'y':
                        continueProgram = true;
                        break;

                    case 'n':
                    case 'N':
                        CW.ErrorPrinter(0);
                        System.Environment.Exit(0);
                        break;

                    default:
                        CW.ErrorPrinter(404);
                        continueProgram = false;
                        break;
                }
            } while (!continueProgram);

        }
        public static string RunAccountNameCreationAndConfirm()
        {
            string? UserName;
            bool confirmAccount;
            do
            {
                CW.Color("y");
                Console.WriteLine("When you create a new account. We will give you a phony amount of $2000.00 USD.");
                CW.Color();
                Console.Write("Account Name: ");
                UserName = Console.ReadLine();
                while (string.IsNullOrEmpty(UserName))
                {
                    CW.ErrorPrinter(404);
                    Console.Write("Account Name: ");
                    UserName = Console.ReadLine();
                }
                Console.Write("You have entered ");
                CW.Color("red");
                Console.Write(UserName);
                CW.Color();
                Console.Write(" Is this correct?");
                CW.YN();
                _ = char.TryParse(Console.ReadLine(), out char continueAccountConfirm);
                CW.Color();
                switch (continueAccountConfirm)
                {
                    case 'Y':
                    case 'y':
                        confirmAccount = true;
                        break;

                    case 'n':
                    case 'N':
                        confirmAccount = false;
                        break;

                    default:
                        CW.ErrorPrinter(404);
                        confirmAccount = false;
                        break;
                }
            } while (!confirmAccount);
            return UserName;
        }
    }
}
