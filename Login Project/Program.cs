using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //login uygulaması projesi, kullanıcı ve şifre istenip doğru giriş yapılması için 3 hak tanılacak, doğru girerse giriş yapılacak, yanlışsa error verilecek

            int hak = 3;
            while (true)
            {
                Console.WriteLine("Enter username : ");
                string kullanıcı = Console.ReadLine();

                Console.WriteLine("Enter password : ");
                string sifre = Console.ReadLine();

                if (kullanıcı == "naber" && sifre == "123456")
                {
                    Console.WriteLine("Logged in successfully");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered a wrong username or password");
                    if (hak > 0)
                    {
                        hak -= 1;
                    }
                    if (hak == 0)
                    {
                        Console.WriteLine("You have entered wrong too many times !");
                        Console.WriteLine("Please try again later");
                        break;
                    }
                }

            }
            Console.ReadLine();

        }
    }
}
