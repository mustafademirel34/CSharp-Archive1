using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    internal class ProductDal
    {
        internal List<Product> GetAll()
        {
            using (ETContext context = new ETContext()) // <using> sonunda bellekten gönder.
            {
                return context.Products.ToList();
            }
        }

        internal List<Product> GetByName(string key)
        {
            using (ETContext context = new ETContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
                // Products içeriğinde ara, her bir elemanın p.Name (isim) içeriyorsa (key) listesini al ve döndür.
            }
        }

        internal Product GetById(int id)
        {
            using (ETContext context = new ETContext())
            {
                return context.Products.SingleOrDefault(p => p.Id == id); // SinleOrDefault
                // Ürünleri incele verilen <id> göre kayıt al. (Birden fazla dönüş olursa hata verir)

                // return context.Products.FirstOrDefault(p => p.Id == id); // FirstOrDefault
                // Products <id> ile eşleşen ilk kayıtı alır, bulamazsa <null> döndürür.
            }
        }

        internal List<Product> GeyByUnitPrice(decimal price)
        {
            using (ETContext context = new ETContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }

        internal List<Product> GeyByUnitPrice(decimal minPrice, decimal maxPrice)
        {
            using (ETContext context = new ETContext())
            {
                return context.Products.Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList();
            }
        }

        internal void Add(Product product)
        {
            using (ETContext context = new ETContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        internal void Update(Product product)
        {
            using (ETContext context = new ETContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal void Delete(Product product)
        {
            using (ETContext context = new ETContext())
            {
                // context.Products.Remove(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
