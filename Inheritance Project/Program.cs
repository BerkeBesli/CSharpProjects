using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monty gobekli = new Monty();
            gobekli.name = "Bebek";             //Monty classından obje yaratmamıza rağmen, Animals classında tanımladığımız değişkenlere değer atayabiliyoruz
            gobekli.gender = "Erkek";           //Monty classından yarattığımız objeyi kullanarak değer atarken, bu değişkenlerin Animals'dan geldiği gözüküyor
            gobekli.age = "2";

            gobekli.showinfo();
            Console.ReadLine();
        }
    }
}
