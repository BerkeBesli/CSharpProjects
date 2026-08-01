using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 10 tane int değer alıp, kaç adet tek kaç adet çift eleman olduğunu bulan, çift değerlerin toplamını ve tek değerlerin toplamını bulan
            //son olarak tek sayıların toplamı mı çift sayıların toplamı mı daha büyük kontrol eden ve hangisinin büyük olduğunu yazdıran kod yazma pratiği,

            int i = 0;
            int j = 0;
            int[] sayılar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekSayıToplamı = 0;
            int ciftSayıToplamı = 0;

            int deger;  //kullanıcıdan alıcağım değeri, değeri istemeden önce tanımlamam gerekiyor. Önüne veri tipi yazarak kolayca tanımlayabiliyorum.

            for (i = 0; i < sayılar.Length; i++)
            {
                Console.Write((i)+". index değerini giriniz ");
                deger = int.Parse(Console.ReadLine());   //kullanıcıdan değerler istenir ve değer değişkenine tanımlanır
                sayılar[i] = deger;                      //değer değişkenine sayı tanımlandıkça, arrayin içi kullanıcıdan alınan değerlerle doldurulur
                //ilk i=0'ken değer istenir ve tanımlanır, sonra döngü başa döner, i=1 olunca tekrar değer istenir ve bu yeni değer 1.indexe tanımlanır ve döngü devam eder
            }
            for (j = 0; j < sayılar.Length; j++)
            {
                if(sayılar[j]%2 == 0)        //sayılar dizisinin 0. indexi 2ye bölünür ve eğer 0 kalırsa demek ki çift değer girilmiştir ve if bloğunun içine girer
                {                            //j değeri 1 artarak sonraki indexe geçer ve her indexteki sayı 2'ye bölünür ve kontrol edilir, döngü böyle devam eder
                    ciftAdetToplam += 1;
                    ciftSayıToplamı += sayılar[j];  //çift sayı girildiyse o sayı, değişkenimize atanır ve döngü döndükçe eklenmeye devam eder
                }
                else if(sayılar[j]%2 == 1)   //eğer 1 kalırsa tek değer girilmiştir ve bu bloğa girer, 
                {
                    tekAdetToplam += 1;
                    tekSayıToplamı += sayılar[j];   //0. indexteki sayıdan başlayıp, her indexteki kontrolde eğer değer tek sayı ise döngünün sonuna kadar eklenmeye devam eder
                }
                
            }
            Console.WriteLine("Çift sayıların toplamı = " + ciftSayıToplamı);
            Console.WriteLine("Tek sayıların toplamı = " + tekSayıToplamı);

            if (tekSayıToplamı < ciftSayıToplamı)
            {
                Console.WriteLine("Çift sayıların toplamı daha büyük");
            }
            else         //eğer sadece iki seçenek varsa 2 tane if bloğu yerine if ve else kullanmak daha az yer kaplar ve göze daha hoş gözükür
            {
                Console.WriteLine("Tek sayıların toplamı daha büyük");
            }
            Console.ReadLine();
