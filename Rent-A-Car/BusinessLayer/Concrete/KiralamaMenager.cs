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
            _kiralamaDAL.Delete(kiralama);
        }

        Kiralama IKiralamaService.GetById(int id)
        {
            return _kiralamaDAL.Get(x => x.kiralamaID == id);
        }

        List<Kiralama> IKiralamaService.GetList()
        {
            return _kiralamaDAL.List();
        }
    }
}
