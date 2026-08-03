using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir class oluşturduktan sonra, o class'ı kullanmak için class'a erişim sağlamak ve obje oluşturmak gerekiyor
            //ilk class'ın ismi, sonra objenin (class için referans ismi) ismi koyulur ve bu şekilde obje oluşturulur

           Naberclass naberimsi1 = new Naberclass(); //sağ taraf yapıcı methodu temsil eder. naberclass()'a bakınca parantez açılıp kapanmasından method olduğunu anlaşılır

            //bir referans oluşturduğumuzda, derleyici ilk sağ taraftan okumaya başlar ve Main'den Naberclass sınıfının yapıcı methoduna gider ve içindeki kodları çalıştırır.
            //naberclass'taki yapıcı method'da olan kodlar çalıştırıldıktan sonra, derleyici bu kodlarla referansı oluşturur (örneğin bu kod'da naberimsi1 referansı)

            //artık naberimsi1 objesi (referansı) üstünden naberclass içindeki methodlar ve propertyler kullanılabilir         

            naberimsi1.naberimsiler = "chigiri";     //class içinde değişkenler (propertyler) tanımlanır ve referans ismi üzerinden bu değişkenlere değer verilebilir
            naberimsi1.laynlar = "nidalee";       //class içinde string veri tipinde tanımlandıysa, kullanılırken de string veri tipinde değer verilmelidir
            naberimsi1.ögrencisayısı = 3;            //böylelikle class içinde tanımlanan değişkenlere değer verilir veya tanımlanır

            naberimsi1.adamlar();      //bu şekilde class içinde tanımladığımız methodlara erişebiliriz ve kullanabiliriz
            naberimsi1.minikler();     //bu şekilde method çağırıldığında, kod bu classtan naberclass'a geçip ordaki methodu çalıştırır ve burada kullanır

            Console.WriteLine("Karakter yoksunu : " + naberimsi1.laynlar);  
            Console.WriteLine("Küçük minik : " + naberimsi1.naberimsiler);    //sadece naberimsiler yazınca değişken görülmez, obje (referans) üzerinden erişilebilir
            Console.ReadLine();
        }
        
    }
}
