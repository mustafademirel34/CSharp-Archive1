using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        private static bool IsPrimeNumber(int number) // Asal sayı kontrol
        {
            // Asal sayı olarak işaretleniyor. İşlem tamamlandığında eğer asal değilse <false> olarak işaretlenecek.
            bool result = true;
            // <i> iki olarak veriliyor. Asal sayılar sadece bire ve kendisine bölündüğü için bunu yapıyoruz.
            // Ayrıca verilen sayının kendisi hesaba katılmaması için <number-1> kullanıyoruz.
            // <i> tek tek artarak number seviyesine geliyor. <number> olan eşitsizliğinde döngü sonlanacak.
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0) // Tek tek sayılar <i> den geliyor. Bölümünden kalan sıfır ise <number> demek ki bir sayıya bölünüyor.
                {
                    result = false; // O zaman bu bir asal sayı olamaz.
                    i = number; // Döngünün devam etmemesi için <i> <number> eşitleniyor.
                }
            }
            return result;

            //for (int i = 2; i < sayi - 1; i++)
            //{
            //    if (sayi % i == 0 || sayi == 1)
            //    {
            //        sonuc = false;
            //        i = sayi;
            //    }
            //}
        }
        private static void ForEachLoop()
        {
            // Bir bilgi kümesindeki verileri tek tek yazdırmak veya üzerinde işlem yapmak için kullanılır.
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            students.ToList().ForEach(student =>
            {
                Console.WriteLine(student);
            });

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            // Önce işlemi uygular, daha sonra şartı kontrol eder.
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
            // Buna göre <number> içerisindeki onu yazdıracak. Ancak kontrole giden <dokuz> şartı sağlamayacak.
            // Bu yüzden sadece ekranda on yazdırılacak. Sayı azaltılmasa bile şartı sağlamıyor.
        }

        private static void WhileLoop()
        {
            // Verilen şart geçerli olduğu sürece işlemi devam ettir.
            // Buna göre sıfırdan büyük olduğu takdirde sayı ekrana yazdırılıacak ve -1 olduğunda bitirilecek.
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void For()
        {
            //Şart sağlanabilir olduğu sürece içerisindeki işlemi devam ettirir.
            for (int i = 100; i >= 0; i = i - 2) // Buna göre 100 olan <i> sayısı sıfırdan büyük ve eşit olduğu sürece işlemi devam ettir.                
            {                                    // Şart sağlanıyor mu? işlemi uygula ve <i> sayısını iki azalt. Başa dön.                                 
                Console.WriteLine(i);            // -2 sağlıyor mu? hayır. Bitir.
            }
            Console.WriteLine("Finished!");
        }
    }
}
