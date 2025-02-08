using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Products_Data_View_With_EntityFramework
{
    internal class ProductDal
    {
        //Database'deki verileri listeye aktarmak
        public List<Product> getAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> getAllByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //Veri tabanına erişerek veri tabanı kapanmadan önce dönen listeye filtreleme yaparve veri tabanı kapanmadan filtrelenmiş listeyi dönerr
                return context.Products.Where((p)=>p.Name.Contains(key)).ToList();
            }
        }

        //Database'e ürün eklemek
        public void addProduct(Product product)
        {
            using (ETradeContext context=new ETradeContext())
            {
               // context.Add(product); diğer yöntem ama pek kullanma

               //entity adındaki parametre girdi(entry) context nesnesine product nesnesi türünde olacak (context.Entry(product))
               var entity = context.Entry(product);
               //parametreye atanan değerin durumu girdi durumlarından eklemeye denk gelecek
               entity.State = EntityState.Added;
               //Değişiklikler kaydedilecek
                context.SaveChanges();
            }
        }

        //Silme işleminde tek değişen entityState durumudur(Deleted)
        public void deleteProduct(Product product)
        {
            using (ETradeContext context = new())  
            {
                // context.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        //Güncelleme işleminde tek değişen entityState durumudur(Modified)
        public void updateProduct(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // context.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
