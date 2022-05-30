using BusinessLayer.Abstract;
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
    public class ArabaMenager : IArabaService
    {
        IArabaDAL _arabaDAL;

        public ArabaMenager(IArabaDAL arabaDAL)
        {
            _arabaDAL = arabaDAL;
        }

        public void arabaDuzenle(Araba araba)
        {
            _arabaDAL.UpDate(araba);
        }

        public void arabaEkle(Araba araba)
        {
            _arabaDAL.Insert(araba);
        }

        public void arabaGuncelle(Araba araba)
        {
            _arabaDAL.UpDate(araba);
        }

        public void arabaSil(Araba araba)
        {
            _arabaDAL.Delete(araba);
        }

        public Araba GetById(int id)
        {
            return _arabaDAL.Get(x => x.arabaID == id);
        }

        public List<Araba> GetList()
        {
            return _arabaDAL.List();
        }

        public List<Araba> GetListByID(int id)
        {
            return _arabaDAL.List(x => x.sirketID == id);
        }
    }
}
