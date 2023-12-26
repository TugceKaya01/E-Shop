using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using EntityLayer.Entities;
using WorkLayer.Concrete;
using PagedList.Mvc;
using PagedList;

namespace E_Shop.Controllers
{
    public class AdminUrunController : Controller
    {
        // GET: AdminUrun
        UrunRepository urunRepository = new UrunRepository();
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View(urunRepository.List());
        }

        public ActionResult Create()
        {
            List<SelectListItem> deger1 = (from i in db.Kategoriler.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Ad,
                                               Value = i.Id.ToString()


                                           }).ToList();
            ViewBag.ktgr = deger1;
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Urun data, HttpPostedFileBase File)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Hata Oluştu");
            }

            string path = Path.Combine("~/Content/Image/" + File.FileName);
            File.SaveAs(Server.MapPath(path));
            data.Image = File.FileName.ToString();
            urunRepository.Insert(data);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            var delete = urunRepository.GetById(id);
            urunRepository.Delete(delete);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            List<SelectListItem> deger1 = (from i in db.Kategoriler.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Ad,
                                               Value = i.Id.ToString()


                                           }).ToList();
            ViewBag.ktgr = deger1;

            var update = urunRepository.GetById(id);
            return View(update);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Update(Urun data, HttpPostedFileBase File)
        {
            var update = urunRepository.GetById(data.Id);
            if (!ModelState.IsValid)
            {
                if (File == null)
                {

                    update.Aciklama = data.Aciklama;
                    update.Ad = data.Ad;
                    update.OnaylıMı = data.OnaylıMı;
                    update.Popular = data.Popular;
                    update.Fiyat = data.Fiyat;
                    update.Stok = data.Stok;

                    update.KategoriId = data.KategoriId;
                    urunRepository.Update(data);
                    return RedirectToAction("Index");
                }
                else
                {

                    update.Aciklama = data.Aciklama;
                    update.Ad = data.Ad;
                    update.OnaylıMı = data.OnaylıMı;
                    update.Popular = data.Popular;
                    update.Fiyat = data.Fiyat;
                    update.Stok = data.Stok;
                    update.Image = File.FileName.ToString();
                    update.KategoriId = data.KategoriId;
                    urunRepository.Update(update);
                    return RedirectToAction("Index");
                }
            }
          
            return View(update); 
           
        }

    }
}