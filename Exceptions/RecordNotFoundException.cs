using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class RecordNotFoundException : Exception
    {
        // Kendi hata türümüzü oluşturuyoruz.
        public RecordNotFoundException(string message) : base(message) // Hata mesajımızı <Exception> gönderiyoruz.
        {

        }
    }
}
