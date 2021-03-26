using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        abstract class Database // Örneği oluşturulamaz.
        {                       // İçerisine sabit metotlar yazılabilir. 
            public void Add()
            {
                Console.WriteLine("Added by default");
            }

            public abstract void Delete(); // Sabit olmayan metotlar <abtract> tarzında yazılır.
                                           // Implementation aşamasında buna müdahale edilir.
        }
        // Bir açıklama daha; <Add()> metodu <SqlServer> için de <Oracle> için de aynıdır.
        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by SqlServer");
            }
        }

        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Oracle");
            }
        }

    }
}
