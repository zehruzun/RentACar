using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayr.Abstract
{
    public interface IKiralamaService
    {
        List<Kiralama> GetList();
        Kiralama GetById(int id);
        void kiralamaEkle(Kiralama kiralama);

        void kiralamaSil(Kiralama kiralama);
        void kiralamaKabul(Kiralama kiralama);

        void kiralamaDuzenle(Kiralama kiralama);
    }
}
