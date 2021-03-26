using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Süper değil mi? Kendi eventimizi yazıyoruz!
    public delegate void StockControl(string value, bool value2); // Parametre alan bir void delegesi oluşturuyoruz.

    internal class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent; // Delege yardımıyla bir event tanımladık.

        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock; // İstenilen değeri, stok sayısını döndürüyoruz.
            }
            set
            {
                // Videodan sonra bazı eklemeler yaptım. İki farklı kontrol yolu var. Hesaplanan değere göre hareket ediyoruz.

                if (value >= 0) // Ürün bittiyse(0) veya hala elimizde varsa buraya düşüyor.
                {
                    // Gelen bilgi bittiyse veya elimizde varsa kaydediyoruz. Zaten eksiye düşerse buraya hiç gelmiyor, hata veriyor.
                    _stock = value; // Gelen değeri field'a set ediyoruz.

                    if (_stock == 0) // Ürün bittiyse "bitti" mesajı veriyoruz. Diğer kontrole uğramasına gerek yok, yapmıyor.
                        StockControlEvent(ProductName, false); // false: ürün bitti demek oluyor.

                    // Stok adedi 15 ve altına düştüğünde ve oluşturduğumuz StockControlEvent'imize abone olmuşsa onu tetikliyoruz.
                    else if (value <= 15 && StockControlEvent != null)
                    {
                        // Parametreye ürün ismini gönderiyoruz, böylelikle şartı sağlayanın hangi ürün olduğu ön taraftan görülüyor.
                        StockControlEvent(ProductName, true); // Tetikliyoruz, true: hala ürün mevcut demektir.
                    }
                }

                else if (value < 0) // Ürün stoktan fazla satılmaya çalışılıyorsa hata ver.
                {
                    throw new NotImplementedException(); // Bittiyse bile verilen değer eksiye düşerse hata verir.
                                                         // Buna göre veritabanına kayıt eklemesini engelleriz.

                    //StockControlEvent(ProductName, false); // Eksiye düşse bile "bitti" mesajı verir.
                }
            }
        }

        // Gelen satış bilgisine göre <Stock> sayısından azaltıyoruz. Buna göre işlemler gerçekleştiriliyor.
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} : Stock Amount : {0}", Stock, ProductName);
            Console.WriteLine("");
        }
    }
}
