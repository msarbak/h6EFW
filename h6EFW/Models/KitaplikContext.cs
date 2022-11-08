using Microsoft.EntityFrameworkCore;

namespace h6EFW.Models
{
    public class KitaplikContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer();

        }
    }
}
