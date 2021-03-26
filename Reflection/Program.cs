using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var tip = typeof(DortIslem); // DortIslem tipini al.
            // Programın çalışması esnasında örnek (instance) oluştur. <tip> tipinde istenen parametreler 6,7. DortIslem tipinde dortIslem'e referans gönder.
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7); //No parameterless constructor defined for this object

            //Console.WriteLine(dortIslem.Topla1(3, 4));
            //Console.WriteLine(dortIslem.Topla2());

            // DortIslem tipinde işlem esnasında bir örnek oluştur, parametresi 6,7. Bununda bir örneğini al.
            var instance = Activator.CreateInstance(tip, 6, 7);

            // DortIslem sınıfının "Topla2" metodunun bilgisini al.
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            // Method bilgisini içeren methodInfo'yu çalıştır. O bir <instance> tipinde, parametresi yok.
            Console.WriteLine(methodInfo.Invoke(instance, null));

            // Biraz karmaşık görünüyor olabilir. Sadece sıradışı yollardan ilerliyor, anlaması zor değil. Yorumlamaya ve eklemeye açık. 6.45

            /**********/

            var _tip = typeof(DortIslem); // var result = _tip.GetCustomAttributes().ToList(); > item.GetType().Name < Att listesini al ve tipi üzerinden ismini ver.
            // var result = _tip.GetMethod("Topla1"); // <result> üzerinde işlem yapabiliyoruz. Mesela bool sonuc = rs.IsPublic;
                                                                                                                    // o metodun erişim seviyesi public mi?
            Console.WriteLine("**********");

            MethodInfo[] metodlar = _tip.GetMethods(); // Verilen tipin Metotlarını alarak bilgilerini referans ver.

            foreach (MethodInfo _methodInfo in metodlar) // Bu bilgilerin içerisinde tek tek gezinmemizi sağlayacak.
            {
                Console.WriteLine("Metot adı: {0}", _methodInfo.Name); // Metodun adı
                foreach (ParameterInfo parameterInfo in _methodInfo.GetParameters()) // Elimizdeki metodun parametreleri arasında gez.
                {
                    Console.WriteLine("Parametre adı: {0}", parameterInfo.Name); // Parametrenin adı
                }
            }

            Console.ReadLine();
        }
    }

    class bilmemneAttribute : Attribute // Sallama bir Attr
    {
       
    }
    public static class Converters
    {
        public static object ObjTransmitter(object val1, object val2)
        {
            dynamic ret;

            try
            {
                foreach (System.Reflection.PropertyInfo pi in val1.GetType().GetProperties())
                {
                    string propName = pi.Name;
                    var type = val1.GetType();
                    var prop = type.GetProperty(propName);
                    var value = prop.GetValue(val1, null);
                    var myType = pi.PropertyType;
                    System.Reflection.PropertyInfo propertyInfo = val2.GetType().GetProperty(propName);
                    propertyInfo.SetValue(val2, ChangeType(value, propertyInfo.PropertyType), null);
                }
            }
            catch (Exception ex)
            {

            }

            ret = val2;
            return ret;
        }
        private static object ChangeType(object value, Type conversion)
        {
            object obj = null;

            try
            {
                var t = conversion;
                if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                {
                    if (value == null)
                        return null;
                    t = Nullable.GetUnderlyingType(t);
                }

                obj = Convert.ChangeType(value, t);
            }
            catch (Exception ex)
            {

            }

            return obj;
        }
    }

    [bilmemne]
    public class DortIslem
    {
        private int _sayi1, _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla1(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
    }
}
