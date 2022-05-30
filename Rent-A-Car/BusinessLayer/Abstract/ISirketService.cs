using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayr.Abstract
{
    public interface ISirketService
    {
        List<Sirket> GetList();
        Sirket GetById(int id);
        void sirketEkle(Sirket sirket);

        void sirketSil(Sirket sirket);
        void sirketOnayla(Sirket sirket);
        void sirketDuzenle(Sirket sirket);
    }
}
