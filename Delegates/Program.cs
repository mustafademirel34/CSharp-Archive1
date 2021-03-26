using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // Delegeler içerisine ancak belirtilen türde metot atabiliriz.
        public delegate void MyDelegate(); // Parametresiz, void delege
        public delegate void MyDelegate2(string text); // <string> parametreli void delege
        public delegate int MyDelegate3(int sayi1, int sayi2); // <int> dönen iki <int> parametreli delege

        static void Main(string[] args)
        {
            Manager manager = new Manager();
            //manager.SendMessage();
            //manager.ShowAlert();

            MyDelegate myDelegate = manager.SendMessage; // Belirtilen türde metot atmalıyız.
            myDelegate += manager.ShowAlert; // <+=> ile daha fazla metot ekleyip <-=> ile de çıkartabiliriz.
            //myDelegate(); // ile çalıştırabiliriz. Delegeler için bir metot gruplaması denilebilir.

            MyDelegate2 myDelegate2 = manager.SendMessage2; // Parametreli
            myDelegate2 += manager.ShowAlert2;
            myDelegate2("Hello"); // Fakat istediği parametreyi verdiğimiz zaman iki metodu da etkilemektedir.

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp; // Son verilen referansı çalıştıracaktır.

            myDelegate3(2,3);
            var sonuc = myDelegate3(2,3);
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }

    class Manager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hi");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful");
        }
        public void SendMessage2(string text)
        {
            Console.WriteLine(text);
        }

        public void ShowAlert2(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
