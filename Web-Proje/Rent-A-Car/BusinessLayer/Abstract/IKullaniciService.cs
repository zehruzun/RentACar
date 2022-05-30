using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayr.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> GetList();
        Kullanici GetById(int id);
        void kullaniciEkle(Kullanici kullanici);

        void kullaniciSil(Kullanici kullanici);
        void kullanıcıKabul(Kullanici kullanici);
        void kullaniciDuzenle(Kullanici kullanici);
    }
}
