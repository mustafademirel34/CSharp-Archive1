using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

        basadon: Console.WriteLine(""); Console.Write("Sayı girin: "); int sayi = Convert.ToInt32(Console.ReadLine());

            bool sonuc = true;
            for (int i = 2; i < sayi - 1; i++)
            {
                if(sayi%i == 0 || sayi == 1)
                {
                    sonuc = false;
                    i = sayi;
                }
            }

            if (sonuc == true)
                Console.WriteLine("O bir asal sayıdır");
            else
                Console.WriteLine("O bir asal değildir");

            goto basadon;
            Console.ReadKey();
        }

        static void Diziler()
        {
            string[] isimler = new string[3] { "Mustafa", "Erdem", "Recep" }; // Üç elemanlı bir dizi oluştur.

            string[] isimler2 = { "Mustafa", "Recep", "Erdem" }; // Sıfırdan başlar.
            isimler2[3] = "Ahmet"; // Dördüncü satır "Ahmet" olsun.

            string[,] isimler3 = new string[4, 3] // Dört satır, üç kolonluk çok boyutlu bir dizi oluştur.
            {
                { "İstanbul","Kocaeli","Bursa" },
                { "Rize","Trabzon","Samsun" },
                { "Muğla","İzmir", "Manisa" },
                { "Antalya","Adana","Mersin" }
            }; // Bir void içerisinde hata veriyor.

            for (int i = 0; i <= isimler3.GetUpperBound(0); i++) // isimler3 dizisinin sıfır boyutununu al.
            {
                // Saymaya sıfırdan başladığı için onu da dahil etmek üzere <= kullanıyoruz.
                for (int j = 0; j <= isimler3.GetUpperBound(1); j++) // isimler3 dizisinin bir boyutunu al.
                {
                    Console.WriteLine(isimler3[i, j]); // Böylelikle satırı alıp kolonları inceleyebiliriz.
                }
                Console.WriteLine("**********");
            }
        }
    }
}
