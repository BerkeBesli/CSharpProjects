using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static classlardan obje oluşturulamaz ve static classlarda kalıtım (inheritance) yapılamaz
            // Customer Musteri = new Customer()      bu şekilde obje oluşturulmaya çalışıldığında hata alınır
            Customer.methodumsu();                  //class static tanımlandığı için obje oluşturmaya gerek olmadan, class ismiyle method çağırılabilir
            Console.ReadLine();  
        }
    }
}
