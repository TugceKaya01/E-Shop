using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;

namespace DataLayer.Context
{
    public class DataContext:DbContext
    {
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        public DbSet<Kullanici> Kullaniciar { get; set; }
    }
}
