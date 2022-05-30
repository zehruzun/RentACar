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
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Sirket> Sirkets { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
