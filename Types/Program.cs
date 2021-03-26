using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bir anahtar sözcüğü karşılığındaki değeri vermektedir. Değer verilerek key alınamaz.
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // Key ve değer tipi <string> olacak.
            dictionary.Add("software","yazılım");
            dictionary.Add("hardware","donanım");

            Console.WriteLine(dictionary["software"]); // olarak alınır.

            foreach (var item in dictionary)
            {
                Console.WriteLine(item); // Sadece key veya değerler de öğrenilebilir > item.Key
            }

            bool sonuc = dictionary.ContainsKey("glass"); // Keylerde "glass" var mı? Aynı kontrolü değerler için de yapabiliriz.

            Console.ReadLine();
        }

        void Lists()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İzmir");
            arrayList.Add("Ankara");
            arrayList.Add(null); // <general> object value değer tipli değer istiyor.

            // String türünde List örneği oluştur. Sadece <string> ile çalışılabilir.
            List<string> cities = new List<string>();

            // <Customer> adında bir class olsun.

            // List<Customer> customers = new List<Customer>(); 
            // customers.Count() ile içerik sayısını alabilirsin.
            // customers.AddRange() ile bir Array ve List içerisindeki <Customer> ögelerini ekleyebilirsin.
            // customers.Contains() ile liste içerisinde değer arayabilirsin. True veya False döndürür.
            // new Customer() olarak veremezsin. Referans olayını hatırlarsak, bunla onun bir ilişkisi yok.
            // customers.IndexOf() ile verilen değerin kaçıncı sırada olduğunu gösterir.
            // customers.LastIndexOf() Aramaya sondan başlar.
            // customers.Insert() ile istediğimiz satıra bilgi ekleyebiliyoruz.
            // customers.Remove() ile istediğimiz satırdaki bilgiyi silebiliyoruz.
            // customers.RemoveAll(c=>c.FirstName == "Salih") liste içerisinde <FirstName> "Salih" olan satırları sil
        }

        void Diziler()
        {
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; // 101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; // 102

            cities2 = cities1; // 102 = 101 >> 101 >> <Cities2> referansına <Cities1> at

            cities1[0] = "İstanbul"; // <Cities1>[0] değeri "Ankara" > "İstanbul" olacak.
            Console.WriteLine(cities2[0]); // Buna göre Cities1'in değerlerini takip eden Cities2'in de [0] değeri "İstanbul" olacak.

            DataTable dataTable; // new DataTable(); yer kaplamaması için yapmasına gerek yok, çünkü zaten aktarım yapılacak.
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
