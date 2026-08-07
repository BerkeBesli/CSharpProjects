using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animals
    {
        public string name;
        public string gender;
        public string age;
        private int height;         //inheritance ile bu class miras alındığında bile, private erişim belirleyicisi olan değişkenler kullanılamıyor

        public void showinfo()
        {
            Console.WriteLine("The name of the animal is : " + name);
            Console.WriteLine("The gender of the animal is : " + gender);
            Console.WriteLine("The age of the animal is : " + age);  
        }
    }
}
