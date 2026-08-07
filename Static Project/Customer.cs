using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_3
{
    public static class Customer
    {
        // public int id;                 static classların içinde static olmayan bir şey tanımlanamaz, tanımlanmaya çalıştığında hata verir
        public static int id;
        public static float height;
        // public void methodumsu();      bu şekilde method tanımlanmaya çalışıldığında da hata verir
        public static void methodumsu()
        {
            Console.WriteLine("Static class içine her şey static tanımlanır");
        }
    }
}
