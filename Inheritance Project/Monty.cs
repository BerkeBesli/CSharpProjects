using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Monty : Animals      //Inheritance bu şekilde alınır
    {
        //bu classta hiç bir şey olmamasına rağmen Animals classını miras aldığı için, Animals classındaki değerler ve methodlar bu class içerisinde gibi kullanılabilir
        //Animals classındaki her değer ve methoda, Monty classı da sahip olur
        //bir class sadece bir classı miras alabilir, iki class aynı anda miras alınamaz
    }
}
