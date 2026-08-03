using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //öğrenci bilgileri yazdıran program
            bool kontrol = true;
            StudentP naber = new StudentP(120207,"Chigiri","Şutvobam",45,32,64,"Ocean College");       //StudentP class'ının içindeki yapıcı methoda parametre yollanılıyor

            Console.WriteLine("Welcome... Please select an action");
            ActionSelection();
              
            while (kontrol)
            {
                string selection = Console.ReadLine();          //kullanıcıdan değer isteniyor ve switch-case için kullanılacak bir değişken tanımlanıyor
                switch (selection)                              //selection değişkeni string olduğu için case'ler yanına da string olarak yazılır
                {
                    case "1":
                        naber.StudentInfo();                    //burada StudentP classımın içinde, öğrenci bilgilerinin yazdığı methodu, yarattığımız objeyi kullanarak çağırdım
                        break;                                  //ve bu case doğruysa kodun sonsuz dönmemesi için break koyuluyor
                    case "2":
                        double avg = naber.StudentAverage();    //+ class kullanılamadığı için, avg adında double veri tipinde değişkene classdan alınan değeri tanımladım
                        Console.WriteLine("This student has a GPA of " + avg); 
                        break;
                    case "3":
                        naber.StudentNaber();
                        break;
                    case "4":
                        kontrol = false;
                        break;                  
                }
            }       
        }
        static void ActionSelection()
        {
            Console.WriteLine("1 - Show student information");
            Console.WriteLine("2 - Show student GPA average");
            Console.WriteLine("3 - Show the school that the student is enrolled to");
            Console.WriteLine("4 - Exit");
        }
        
    }
}
