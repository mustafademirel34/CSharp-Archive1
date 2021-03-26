using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length; // Harf sayısı
            var result2 = sentence.Clone(); // Klonlar, referansı

            bool result3 = sentence.EndsWith("ğ"); // Sonu <ğ> ile bitiyor mu
            bool result4 = sentence.StartsWith("My name"); // Başı <My name> ile başlıyor mu

            var result5 = sentence.IndexOf("name"); // Cümle içerisinde <name> kaçıncı karakterden başlıyor.
            var result7 = sentence.LastIndexOf(" "); // Aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, "); // Cümleye <0> karakterinden <Hello,> ekler.
            var result9 = sentence.Substring(3, 4); // <3> karakterden <4> karakter arasındakini alır
            var result10 = sentence.ToLower(); // Cümleyi küçültür
            var result11 = sentence.ToUpper(); // Cümleyi büyültür
            var result12 = sentence.Replace(" ", "-"); // Boşlukları <-> ile değiştir.
            var result13 = sentence.Remove(2, 5); // <2> <5> arasındakileri sil
            if (!string.IsNullOrWhiteSpace(""))
            {

            }
            if (string.IsNullOrEmpty(""))
            {

            }
            string city = "İstanbul", country = "Turkey";
            Console.WriteLine(String.Format("{0} {1}", city, country)); // olarak kullanabilirsin.
            Console.WriteLine($"{city} {country}"); // bu daha havali -R.S
            Console.WriteLine(city+" "+ country);
        }
    }
}
