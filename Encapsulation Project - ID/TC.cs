using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Project_1
{
    public class TC
    {
        private string tcvariable;

        public string tcno
        {
            get
            {
                return tcvariable.Substring(0,5)+"******";
            }
            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {
                            //eğer girilen karakter sayıysa sorun yok ve for döngüsü çalışmaya devam edebilir
                        }
                        else
                        {
                            kontrol = true;                              //eğer girilen karakter sayı harici bir değerse, kontrol true değeri alır ve for döngüsü durdurulur
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("You have entered a wrong value");     //kontrolün başarısız olduğu belirtilir
                    }
                    else
                    {
                        tcvariable = value;                                      //kontrol başarılıysa, değişken vereceğimiz değeri üstüne alır
                    }


                }
                else
                {
                    Console.WriteLine("You didn't enter the correct amount of numbers");
                }


            }

        }
    }
}
