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
    public class SirketMenager : ISirketService
    {
        ISirketDAL _sirketDAL;
        public SirketMenager(ISirketDAL sirketDAL)
        {
            _sirketDAL = sirketDAL;
        }

        public Sirket GetById(int id)
        {
            return _sirketDAL.Get(x => x.sirketID == id);
        }

        public List<Sirket> GetList()
        {
            return _sirketDAL.List();
        }

        public void sirketDuzenle(Sirket sirket)
        {
            _sirketDAL.UpDate(sirket);
        }

        public void sirketEkle(Sirket sirket)
        {
            _sirketDAL.Insert(sirket);
        }

        public void sirketSil(Sirket sirket)
        {
            sirket.sirketDurum = false;
            _sirketDAL.UpDate(sirket);
        }

        public void sirketOnayla(Sirket sirket)
        {
            sirket.sirketDurum = true;
            _sirketDAL.UpDate(sirket);
        }
    }
}
