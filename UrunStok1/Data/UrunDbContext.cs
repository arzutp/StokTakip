using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrunStok1.Data
{
    public class UrunDbContext : DbContext
    {
        #region Contructor
        public UrunDbContext(DbContextOptions<UrunDbContext> options)
                : base(options)
        {
        }
        #endregion
        #region Public properties
        public DbSet<Urun> Urun { get; set; }
        #endregion
        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>().HasData(GetUrunler());
            base.OnModelCreating(modelBuilder);
        }
        #endregion
        #region Private methods
        private List<Urun> GetUrunler()
        {
            return new List<Urun>
    {
        new Urun { Id = 1001, UrunAdi = "Laptop", Stok = 20, Fiyat = 10000, Aciklama ="Oyun bilgisayarı"},
        new Urun { Id = 1002, UrunAdi = "Microsoft Office", Stok = 99, Fiyat = 500, Aciklama ="Office Application"},
        new Urun { Id = 1003, UrunAdi = "Lazer Mouse", Stok = 12, Fiyat = 2000, Aciklama =" "},
        new Urun { Id = 1004, UrunAdi = "USB Storage", Stok = 5, Fiyat = 200, Aciklama ="64GB"}
    };
        }
        #endregion
    }
}
