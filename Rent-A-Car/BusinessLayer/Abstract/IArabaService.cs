using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IArabaService
    {
        List<Araba> GetList();
        List<Araba> GetListByID(int id);
        Araba GetById(int id);
        void arabaEkle(Araba araba);
        void arabaSil(Araba araba);
        void arabaDuzenle(Araba araba);
        void arabaGuncelle(Araba araba);
    }
}
