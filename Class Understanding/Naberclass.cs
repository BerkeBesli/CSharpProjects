using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training____
{
    internal class Naberclass     //projemize add kısmından class ekleyerek şuan naberclass oluşturuldu
    {
        public int ögrencisayısı;      //burada classımın içine propertyler tanımladım ve bu özellikler farklı veri tiplerinde olabilir
        public string laynlar;         //propertyler, özellikler, değişkenler olarak da adlandırılır ve bunlar classın içine tanımlanır
        public string naberimsiler;    //bunlar benzetme yapılırsa, class'a özellik tanımlamak gibidir

        public Naberclass()    //yapıcı method'dur (constructor) bu şekilde tanımlanır. Referans oluşturulmak istenildiğinde derleyici ilk buraya gelir ve kodları çalıştırır
        {                      
            Console.WriteLine("Constructor oluşturuldu");             //kodları çalıştırdıktan sonra class'ı kullanabilmemiz için belirlediğimiz bir referans oluşturur
        }

        public void adamlar()          //burada da classımın içine iş yapan methodlar koydum
        {
            Console.WriteLine("Adamlar aranıyor...");    //bunlar da class'a görev tanımlamak gibidir, yapılacak bir iş verilir
        }
        public void minikler()         
        {
            Console.WriteLine("Karakterler ölçülüyor...");
        }
            
       //classlar, yazılan methodları, fieldları, değişkenleri (propertyleri) tutan büyük bir container gibidir ve hepsini tutma görevini yapar
       //eğer class bir oda ise, propertyler ve methodlar da odanın içindeki eşyalara benzer

    }
}
