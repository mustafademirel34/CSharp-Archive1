using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product ssd = new Product(90);
            ssd.ProductName = "Samsung SSD";
            ssd.StockControlEvent += Ortak_StockControlEvent; // Bx45

            Product mouse = new Product(90);
            mouse.ProductName = "SteelSeries Mouse";
            mouse.StockControlEvent += Ortak_StockControlEvent; // Bx45

            // Bx45 : Aynı event metoduna bağladım. İsim Event üzerinden geliyor. 
            // Bunu tür olarak kabul edebiliriz.
            // Örnekleri oluşturulan ürünlerin özellikleri ayrı kullanılıyor zaten.

            for (int i = 0; i < 20; i++)
            {
                ssd.Sell(10);
                mouse.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Ortak_StockControlEvent(string value, bool value2)
        {
            if(value2==false)
            {
                Console.WriteLine("{0} has finished", value);
            }
            else
            {
                Console.WriteLine("{0} about to finish", value);
            }

          

        }
    }
}
