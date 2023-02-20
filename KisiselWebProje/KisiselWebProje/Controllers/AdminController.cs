using KisiselWebProje.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWebProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int ID)
        {
            var ag = c.Anasayfas.Find(ID);
            return View("AnaSayfaGetir",ag);
        }
        public ActionResult AnaSayfaGuncelle(Anasayfa x)
        {
            var ag= c.Anasayfas.Find(x.ID);
            ag.isim = x.isim;
            ag.profil = x.isim;
            ag.unvan = x.isim;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult İkonListesi()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);
        }
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            c.ikonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }
        public ActionResult ikonGetir(int ID)
        {
            var ig = c.ikonlars.Find(ID);
            return View("ikonGetir", ig);
        }
        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.ikonlars.Find(x.ID);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }
        public ActionResult ikonSil(int ID)
        {
            var sl = c.ikonlars.Find(ID);
            c.ikonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("İkonListesi");
        }
    }
}