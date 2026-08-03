using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             TC kimlik = new TC();

             kimlik.tcno = "98765432103";

             Console.WriteLine("Your ID number is :" + kimlik.tcno);
             Console.ReadLine();
        }
    }
}
