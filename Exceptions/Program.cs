using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        internal static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        internal static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        static void Main(string[] args)
        {
            
            HandleException(() => // HandleException adında bir metot oluşturduk. < () Aksiyon > < => Şudur > < { } Budur >
            {                     // Buraya kontrol ettirmek istediğimiz metodu gönderiyoruz.
                Find(); // Buraya kodları da yazabiliriz.
            });

            // HandleException(()=>Find());

            Func<int,int,int> add = Topla; // Fonksiyonun işlevi dönüş tipini zorunlu şekilde belirtmemiz ve dönüş almamızdır.

            Console.WriteLine(add(3,5)); // Fonksiyonu çalıştırma esnasında parametre bilgilerini gönderiyoruz.

            Func<int> getRandomNumber = delegate() // Delegate() şeklindeki kodlar <int> döndüren <Func> atılıyor. 
            {                                      // Delegate() yerine metod adresi de verebiliriz.
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = 
                () => new Random().Next(1, 100); // Parametresiz constructor'a kod belirliyoruz, onu <Func<int>> atıyoruz.

            Console.ReadLine();
        }

        // Bir deneme yaptım. HandleException'u string döndürdüm. Aksiyon verdiğimiz tanımdan geri dönüş çektim. Bu işe yarar.
        private static void HandleException(Action action) // Bir aksiyon parametresi istiyoruz. Oradan <Find()> gelecek.
        {
            try // Try catch ile bunu kontrol ediyoruz.
            {
                action.Invoke(); // <action> parametresindekileri çağır ve buraya getir diyoruz.
            }
            catch (RecordNotFoundException exception) // Record kendi oluşturduğumuz bir hata.
            {
                Console.WriteLine("Hey bu bizim hatamızz :)");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> isimler = new List<string> { "Ahmet", "Murat", "Mustafa" };

            if (!isimler.Contains("Fatih")) // isimler listesinde "Fatih" yoksa
            {
                throw new RecordNotFoundException("Record Not Found!"); // Hata at
                // Kendi hata mesajımızı oluşturduğumuz hata türüne gönderiyoruz. O da <Exception> classının <base> gönderiyor.
                // Böylelikle istediğimiz içerikte hata vermesini sağlıyoruz.
            }

        }

        void ExceptionIntro()
        {
            try
            {

            }
            catch (IndexOutOfRangeException exception)
            {
                // Hatanın türü IndexOutOfRangeException ise buraya düşer.
                // Hatanın düşmesini ve buna göre hangi yol izleneceği bu şekilde belirlenebilir.
                // Türden bağımsız farklı bir sonuç çıkarsa aşağı atar.
            }
            catch (Exception exception)
            {
                // Bu bilgi veritabanına loglanarak uygulama uzaktan kontrol edilebilir.
                // exception.InnerException varsa hata konusunda daha detaylı bilgi verecektir.
            }
        }
    }
}
