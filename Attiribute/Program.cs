using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attiribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { firstName = "Mustafa", lastName = "Demirel", Age = 21 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }

        [ToTable("Customers")]
        // [ToTable("Products")]
        class Customer
        {
            [RequiredProperty]
            public string firstName { get; set; }
            [RequiredProperty]
            public string lastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }

        class CustomerDal
        {
            [Obsolete("Buraları karıştırma bro, AddNew kullan hade")] // Eski bir metot-class olduğunu belirtir, yanında mesaj gönderebiliriz.
            internal void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2}", customer.firstName, customer.lastName, customer.Age);
            }

            internal void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2}", customer.firstName, customer.lastName, customer.Age);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)] // RequiredPropertyAttribute sadece <class> lara uygulanabilir.
    class RequiredPropertyAttribute : Attribute                          // Birden fazla seçilebilir yapabiliriz. | AttributeTargets.Field
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)] // AllowMultiple ile örneğin bir <class> üzerinde birden fazla
    class ToTableAttribute : Attribute                              // - tanımlanabileceğini kontrol ederiz. Şuan sadece bir adet olmalıdır.
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
