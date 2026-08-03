using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
namespace Student_Project
{
    internal class StudentP
    {
        private int ID;                //burada değişken tanımlanıyor ama değişkenlere değer tanımlanmıyor
        private string name;           //aşağıda bulunan yapıcı methodumuzdan değişkenlerle aynı veri tipinde parametreler isteniyor
        private string surname;        //kafa karıştırmaması için değişkenlere benzer isimle parametreler vermek daha iyi oluyor ve daha hoş duruyor
        private int mid1;              
        private int mid2;
        private int final;
        private string school;

        public StudentP(int naberID, string nabername, string nabersurname, int nabermid1, int nabermid2, int naberfinal, string naberschool)    //parametre isteniyor
        {
            ID = naberID;                //yapıcı method'da istenilen parametreler program.cs'deki main methodun içinde veriliyor
            name = nabername;
            surname = nabersurname;     //burada StudentP class'ımın içinde tanımladığım değişkenlere, bana parametre olarak gelen değerleri tanımla deniyor
            mid1 = nabermid1;
            mid2 = nabermid2;
            final = naberfinal;
            school = naberschool;
        }
       
        public void StudentInfo()   //bu method öğrenci bilgilerini tanımlanan değişkenlerle oluşturuyor
        {
            Console.WriteLine("Student ID : " + ID);
            Console.WriteLine("Student name : " + name);
            Console.WriteLine("Student surname : " + surname);
            Console.WriteLine("Place of education : " + school);
            Console.WriteLine("Student first exam : " + mid1 + " second exam : " + mid2 + " final exam : " + final);         
        }

        public double StudentAverage()   //bu method alınan değerlerle öğrencinin ortalamasını hesaplıyor
        {
            double sumsum = mid1 * 0.2 + mid2 * 0.2 + final * 0.6;
            return sumsum;   //mid1, mid2, final değerlerini kullanıcıdan alıp, methodum çalıştıktan sonra, 
                             //sumsum değişkenine değerler tanımlanınca method başka yerde çağırıldığında, çağırıldığı yere değer atamak için return kullanılır
        }
        public void StudentNaber()
        {
            Console.WriteLine("The student's school is : " + school);
        }


        /*
        public void StudentAverage()
        {
            int percentage1 = (mid1 * 20) / 100;
            int percentage2 = (mid2 * 20) / 100;                    eğer değer döndürmeden yapmak istenilseydi ortalama böyle de bulunabilirdi ama uğraştırıcı ve yer kaplayıcı
            int percentage3 = (final * 60) / 100;
            int average = percentage1 + percentage2 + percentage3;
        }
        */
    }
}
