using BusinessLayer.Abstract;
using BusinessLayr.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KiralamaMenager : IKiralamaService
    {
        IKiralamaDAL _kiralamaDAL;

        public KiralamaMenager(IKiralamaDAL kiralamaDAL)
        {
            _kiralamaDAL = kiralamaDAL;
        }
        public void kiralamaDuzenle(Kiralama kiralama)
        {
            throw new NotImplementedException();
        }

        public void kiralamaEkle(Kiralama kiralama)
        {
            _kiralamaDAL.Insert(kiralama);
        }

        public void kiralamaSil(Kiralama kiralama)
        {
            kiralama.kiralamaDurum = false;
            _kiralamaDAL.UpDate(kiralama);
        }

        public void kiralamaKabul(Kiralama kiralama)
        {
            kiralama.kiralamaDurum = true;
            _kiralamaDAL.UpDate(kiralama);
        }

        public Kiralama GetById(int id)
        {
            return _kiralamaDAL.Get(x => x.kiralamaID == id);
        }

        public List<Kiralama> GetList()
        {
            return _kiralamaDAL.List();
        }
    }
}
