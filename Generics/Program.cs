using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class ve Abstract classlar <Generic> olabildiği gibi metotlar da olabilir.

            Utilities utilities = new Utilities();

            // Generic tarzında <string> tipte metot oluşturduk, liste şeklinde sonuç alacağız.
            // İşlem verilerini gönderiyoruz. Buna göre metotun hangi nesne üzerinde çalışacağını da vermeliyiz.
            List<string> result = utilities.BuildList<string>("İstanbul", "Ankara", "İzmir");


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Mustafa" }, new Customer { FirstName = "Ahmet" });
            foreach (var item in result2) // Verilen değerleri geriye List<Customer> şeklinde döndürecektir.
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        internal List<T> BuildList<T>(params T[] items) // Verilen tipe göre liste döndürür.
        {   // Listenin tipi, metodun ne üzerinde çalışacağı (gönderirken de belirtiyoruz), çoklu <T> tipinde bilgiler
            return new List<T>(items); // <items> kullanarak yeni liste oluştur ve döndür
        }
    }

    interface IPermit { /*Bx34*/ };

    class Product : IPermit
    {

    }

    class Customer : IPermit
    {
        public string FirstName { get; set; }
    }

    class ProductDal : IProductDal // IRepository<Product> olarak ayarlayabiliriz.
    {                              // Ancak tabiri uygunsa implement'i, base'den aldığı için interface kişiselleştirmesi yapamayız.
                                   // Ancak bunun yerine örneğin <ProductDal> içerisine gerekli metotlar yazılabilir.
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SpecialProduct()
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal // IRepository<Customer>
    {                                // Her metot tüm değerlerle sabitse kullanılabilir.
        public void Add(Customer product)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
        public void Custom()
        {
            throw new NotImplementedException();
        }
    }

    interface IProductDal : IRepository<Product>
    {
        // <Interface> parametre gönderir gibi <Type> gönderebilir ve üzerinden implement edebiliriz.
        void SpecialProduct();
    }

    interface ICustomerDal : IRepository<Customer>
    {
        // <Interface> parametre gönderir gibi <Type> gönderebilir ve üzerinden implement edebiliriz.
        void Custom();
    }

    // Kısıtlama: IRepository'den implement alan Interface'lerin, IR'e izin verdiğimiz tipleri göndermesini sağlayabiliriz.
    interface IRepository<T> where T: class, IPermit, new () // Buna göre T: <class> olmalıdır. Sadece sınıflara izin verilecektir.
    {   // <Type> gerektiren bir Interface                   // <string> kabul ediliyor. new() > Bunu engellemek için örneği türetilmelidir diyoruz.
        // Metot örneklerini yazıyoruz.                      // Farklı sınıfların işe karışmaması içinizin verdiğimiz sınıfları,
        // <T> yerine karşıdan gelen nesne yer alacak.       // - aynı interface'den inherit ediyoruz. IPermit <Bx34>

        List<T> GetAll();
        void Add(T product);

        // T Get(int id);
        // void Update(T product);
        // void Delete(T product);
    }
}
