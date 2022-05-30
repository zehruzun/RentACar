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

        public ActionResult Index()
        {
            return View();
        }

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
            return View();
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