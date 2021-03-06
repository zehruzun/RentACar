using BusinessLayer.Concrete;
using BusinessLayr.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar_Proje.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        ArabaMenager arabamenager = new ArabaMenager(new EFArabaDAL());
        SirketMenager sirketMenager = new SirketMenager(new EFSirketDAL());
        KiralamaMenager kiralamaMenager = new KiralamaMenager(new EFKiralamaDAL());
        KullaniciMenager kullaniciMenager = new KullaniciMenager(new EFKullaniciDAL());

        public ActionResult Index()
        {
            return View();
        }

        /*
                 [HttpGet]
        public ActionResult arabaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult arabaEkle(Araba p)
        {
            arabamenager.arabaEkle(p);
            return RedirectToAction("getArabaList");
        }
         */
        [HttpGet]
        public ActionResult SirketKayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SirketKayit(Sirket p)
        {
            sirketMenager.sirketEkle(p);
            return RedirectToAction("sirketListesi");
        }

        public ActionResult sirketListesi()
        {
            var sirketvalues = sirketMenager.GetList();
            return View(sirketvalues);
        }

        public ActionResult sirketArabaList(int id)
        {
            var arabavalues = arabamenager.GetListByID(id);
            return View(arabavalues);
        }

        [HttpGet]
        public ActionResult kullaniciKayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult kullaniciKayit(Kullanici p)
        {
            kullaniciMenager.kullaniciEkle(p);
            return RedirectToAction("kullaniciListesi");
        }
        [HttpGet]
        public ActionResult SirketGiris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SirketGiris(Sirket p)
        {
            Context c = new Context();
            var adminUser = c.Sirkets.FirstOrDefault(x => x.sirketMail == p.sirketMail && x.sirketSifre == p.sirketSifre);
            if(adminUser != null)
            {

                return RedirectToAction("arabaList");
            }

            else
            {
                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult KullaniciGiris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KullaniciGiris(Kullanici p)
        {
            Context c = new Context();
            var adminUser = c.Kullanicis.FirstOrDefault(x => x.kullaniciMail == p.kullaniciMail && x.kullaniciSifre == p.kullaniciSifre);
            if (adminUser != null)
            {

                return RedirectToAction("arabaList");
            }

            else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult ArabaKirala()
        {
            return View();
        }

        public ActionResult ProfilGoruntule()
        {
            return View();
        }

        public ActionResult ArabaList()
        {
            var arabavalues = arabamenager.GetList();
            return View(arabavalues);
        }

        public ActionResult ArabaDetay()
        {
            return View();
        }

        public ActionResult KiralamaGecmisi()
        {
            return View();
        }
    }
}