using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Satici> Satici { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
    }
}
