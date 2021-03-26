using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 60;
            Cikart(ref sayi);
            Console.WriteLine(sayi.ToString());

            VerilenleriTopla(3, 4, 5, 6);

            Console.ReadKey();
        }

        //Default değerler her zaman parametrelerin sonunda olur. (20'li ifade başta olamaz)
        static int Topla(int number1, int number2 = 20)
        {
            return number1 + number2;
        }

        // Referans olarak değişken istenir. Ancak önceden değer verilmesi gerekmektedir.
        // Buna göre ref alınan değişken metot içerisinde değiştirilebilir. 
        // <out keyword> buna gerek yoktur. Sadece <ref> <out> ile değiştirilir.
        static void Cikart(ref int number1)
        {
            if (number1 >= 50)
                number1 = 21;
        }

        static int VerilenleriTopla(params int[] numbers)
        {
            int toplam = 0;
            foreach (int i in numbers)
            {
                toplam += i;
            }
            return toplam;

            // Farklı bir yol; return numbers.Sum(); < Hepsini toplatıp gönderir.
        }

       

    }
}
