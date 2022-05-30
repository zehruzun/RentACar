using BusinessLayr.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayr.Concrete
{
    public class KullaniciMenager : IKullaniciService
    {
        IKullaniciDAL _kullaniciDAL;
        int kullaniciId;
        public KullaniciMenager(IKullaniciDAL kullaniciDAL)
        {
            _kullaniciDAL = kullaniciDAL;
        }

        public Kullanici GetById(int id)
        {
            return _kullaniciDAL.Get(x => x.kullaniciID == id);
        }

        public List<Kullanici> GetList()
        {
            return _kullaniciDAL.List();
        }

        public void kullaniciDuzenle(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public void kullaniciEkle(Kullanici kullanici)
        {
            _kullaniciDAL.Insert(kullanici);
        }

        public void kullaniciSil(Kullanici kullanici)
        {
            kullanici.kullaniciDurum = false;
            _kullaniciDAL.UpDate(kullanici);
        }

        public void kullanıcıKabul(Kullanici kullanici)
        {
            kullanici.kullaniciDurum = true;
            _kullaniciDAL.UpDate(kullanici);
        }
    }
}
