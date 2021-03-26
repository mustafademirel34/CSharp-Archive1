using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soyut nesnelerdir, örneği oluşturulamaz.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerDal(),
                new MySqlServerDal(),
                new OracleServerDal()
            };
            // Inheritance alan <class> kullanılabilir.

            foreach(ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }

        }
    }
}
