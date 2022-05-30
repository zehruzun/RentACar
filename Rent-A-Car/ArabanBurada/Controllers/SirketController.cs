using BusinessLayer.Concrete;
using BusinessLayr.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar_Proje.Controllers
{
    public class SirketController : Controller
    {
        // GET: Admin
        ArabaMenager arabamenager = new ArabaMenager(new EFArabaDAL());
        SirketMenager sirketMenager = new SirketMenager(new EFSirketDAL());
        KiralamaMenager kiralamaMenager = new KiralamaMenager(new EFKiralamaDAL());
        KullaniciMenager kullaniciMenager = new KullaniciMenager(new EFKullaniciDAL());

        public ActionResult getArabaList()
        {
            var arabavalues = arabamenager.GetList();
            return View(arabavalues);
        }

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

        public ActionResult arabaSil(int id)
        {
            var arabavalue = arabamenager.GetById(id);
            arabamenager.arabaSil(arabavalue);
            return RedirectToAction("getArabaList");
        }

        public ActionResult arabaDuzenle(int id)
        {
            var arabavalue = arabamenager.GetById(id);
            arabamenager.arabaDuzenle(arabavalue);
            return RedirectToAction("getArabaList");
        }

        [HttpGet]
        public ActionResult editAraba(int id)
        {
            var arabavalue = arabamenager.GetById(id);
            return View(arabavalue);
        }

        [HttpPost]
        public ActionResult editAraba(Araba araba)
        {
            arabamenager.arabaGuncelle(araba);
            return RedirectToAction("getArabaList");
        }

        public ActionResult KiralamaGecmisi()
        {
            return View();
        }

        public ActionResult KiralamaOnay()
        {
            var kiralamavalues = kiralamaMenager.GetList();
            return View(kiralamavalues);
        }

        public ActionResult kiralamaRed(int id)
        {
            var kiralamavalues = kiralamaMenager.GetById(id);
            kiralamaMenager.kiralamaSil(kiralamavalues);
            return RedirectToAction("Anasayfa");
        }

        public ActionResult kiralamaKabul(int id)
        {
            var kiralamavalues = kiralamaMenager.GetById(id);
            kiralamaMenager.kiralamaKabul(kiralamavalues);
            return RedirectToAction("Anasayfa");
        }

        public ActionResult SirketAnasayfa()
        {
            return View();
        }

        public ActionResult ArabaDetay()
        {
            return View();
        }

        public ActionResult Anasayfa()
        {
            return View();
        }
    }
}