using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access Modifiers - Erişim Değiştiricileri

            // < private > tanımlanan blok içerisinde kullanılabilir.

            // < protected > inheritance edilen yerde kullanılabilir.

            // Bir <class> default'u internal 'dır.

            // < internal > proje içerisinde istediğin yerden çağırabilirsin.

            // Class içerisine class yerleştirilebilir.

            // < public > farklı projelerden de kullanabilirsin.

            // < static > Class üzerinden metotları hemen çağırabilmemizi sağlar.

            // < static > olmayan < class > içerisinde < static > metotlar bulunabilir.
            // Ancak class < static > ise içerisindeki metotlar da < static > olmalıdır.

            PersonManager personManager = new PersonManager("Merhabalar aQ");
            personManager.Add();

            Console.ReadLine();
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }

            public void Message()
            {
                Console.WriteLine("{0} Message",_entity);
            }
        }

         class PersonManager : BaseClass
        {
            public PersonManager(string entity) : base(entity) // PM bilgi istiyor, bu bilgi <base> gönderiliyor.
            {
                // <BaseClass> bilgi gerektiriyor, <inheritance> eden constructor bunu gönderiyor.
                // Belki bir bakıma izinsiz <inheritance> lara karşı önlem alınabilir böylelikle.
            }

            public void Add()
            {
                Console.WriteLine("Added!");
                Message(); // <Base> metot çalıştırılıyor.
            }
        }
    }
}
