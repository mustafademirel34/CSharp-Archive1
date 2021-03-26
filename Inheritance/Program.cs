using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{ FirstName = "Ahmet" },
                new Student{ FirstName= "Mehmet" },
                new Customer{ FirstName = "Zehra" }
            };

            foreach (var item in persons)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Student : Person // İmplement için interface ve inheritance yan yana kullanılabilir.                      
        {                      // Dikkat edilmesi gereken husus; inheritance önce interface sonra yazılmalıdır.
                               // Default değerlerin sona yazılması gerektiği gibi bir durum söz konusudur.
            public string Department { get; set; }
        }

        class Customer : Person
        {
            public string Company { get; set; }
        }
    }
}
