using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Products_Data_View_With_EntityFramework
{
    internal class ETradeContext:DbContext
    {
        // Database işlemlerini yapmak için bir DbSet Oluşturuyoruz.
        public DbSet<Product> Products { get; set; }

        // Konfigurasyon dosyasına ulaşmak için konfigurasyon ayarları uygulayıp referansını gösteriyooruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bu kısımda ise konfigurasyon dosyasındaki connection stringe atanan ada göre ulaşım sağlanır
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ETradeContext"].ConnectionString);
        }

    }
}
