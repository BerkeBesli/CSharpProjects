using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 1000;

            Console.WriteLine("Welcome to the Kutuk ATM !");

            Console.WriteLine("Please select a process");
            Console.WriteLine("1 - Show balance");
            Console.WriteLine("2 - Make a withdrawal");
            Console.WriteLine("3 - Make a deposit");
            Console.WriteLine("4 - Exit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Your balance is : " + balance);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("How much would you like to withdraw ?");
                    int money = int.Parse(Console.ReadLine());
                    Console.WriteLine("You have withdrawn :" + money);
                    Console.WriteLine("The amount left in your balance is : " + (balance - money));
                    Console.ReadLine();
                    if (money > 1000)
                    {
                        Console.WriteLine("You don't have enough money in your account");
                        Console.ReadLine();
                    }
                    break;
                    case "3":
                    Console.WriteLine("Select the amount you would like to deposit");
                    int dollars = int.Parse(Console.ReadLine());
                    Console.WriteLine("You have deposited : " + dollars);
                    Console.WriteLine("You now have : " + (balance + dollars));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("You have exited the ATM");
                    Console.WriteLine("Have a nice day !");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    Console.ReadLine();
                    break;
                    
            }
        }
    }
}
