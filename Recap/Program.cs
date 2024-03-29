﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger(); // Özelliğin hangi metoda bağlı olduğunu çalıştırmadan önce belirtiyoruz.
            customerManager.Add(); // Belirlediğimiz <ILogger> bağlı metodun <Log()> çalıştırabiliriz.

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger()); // Bir logger versiyonu göndermeliyiz.
            employeeManager.Log();

            Console.ReadLine();
        }

        class CustomerManager
        {
            public ILogger logger { get; set; } // Bir interface özelliği oluşturuluyor
            public void Add()
            {
                logger.Log(); // Özelliğin <Log()> metodu çalıştırılıyor.
                              // Ancak özelliğin neye bağlı olduğu belirtilmemiş.
                Console.WriteLine("Customer Added!");
            }
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database!");
            }
        }

        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to file!");
            }
        }

        interface ILogger
        {
            void Log();
        }

        class EmployeeManager
        {
            ILogger _logger;
            // logger versiyonunu constructor üzerinden alabilirsin.
            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }

            public void Log()
            {
                _logger.Log();
            }
        }

    }
}
