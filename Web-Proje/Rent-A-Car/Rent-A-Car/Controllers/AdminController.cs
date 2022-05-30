using BusinessLayer.Concrete;
using BusinessLayr.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar_Proje.Controllers
{
    public class AdminController : Controller
    {
        ArabaMenager arabamenager = new ArabaMenager(new EFArabaDAL());
        SirketMenager sirketMenager = new SirketMenager(new EFSirketDAL());
        KiralamaMenager kiralamaMenager = new KiralamaMenager(new EFKiralamaDAL());
        KullaniciMenager kullaniciMenager = new KullaniciMenager(new EFKullaniciDAL());
        // GET: AnaAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KullaniciOnay()
        {
            return View();
        }

        public ActionResult sirketOnay()
        {
            var sirketvalues = sirketMenager.GetList();
            return View(sirketvalues);
        }

        public ActionResult sirketRed(int id)
        {
            var sirketvalue = sirketMenager.GetById(id);
            sirketMenager.sirketSil(sirketvalue);
            return RedirectToAction("sirketOnay");
        }

        public ActionResult sirketKabul(int id)
        {
            var sirketvalue = sirketMenager.GetById(id);
            sirketMenager.sirketOnayla(sirketvalue);
            return RedirectToAction("sirketOnay");
        }

        public ActionResult kullaniciOnay()
        {
            var kullanicivalue = kullaniciMenager.GetList();
            return View(kullanicivalue);
        }

        public ActionResult kullaniciRed(int id)
        {
            var kullanicivalue = kullaniciMenager.GetById(id);
            kullaniciMenager.kullaniciSil(kullanicivalue);
            return RedirectToAction("kullaniciOnay");
        }

        public ActionResult kullaniciKabul(int id)
        {
            var kullanicivalue = kullaniciMenager.GetById(id);
            kullaniciMenager.kullanıcıKabul(kullanicivalue);
            return RedirectToAction("kullaniciOnay");
        }


        /**
        [HttpPost]
        public ActionResult sirketOnay(int id)
        {
            var sirketvalue = sirketMenager.GetById(id);
            sirketvalue.sirketDurum = true;
            sirketMenager.sirketSil(sirketvalue);
            return RedirectToAction("SirketOnay");
        }**/

        public ActionResult AdminGiris()
        {
            return View();
        }
    }
}