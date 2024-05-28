using Microsoft.AspNetCore.Mvc;
using CoreDepartman.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
namespace CoreDepartman.Controllers
{
    public class departmentController : Controller
    {
        Context db=new Context();
   
        public IActionResult Index()
        {
            var degerler = db.departmanlars.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniDepartman() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(departmanlar dep) 
        {
            db.departmanlars.Add(dep);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult SilDepartman(int id)
        {
            var sil=db.departmanlars.Find(id);
            db.departmanlars.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GuncelleDepartman (int id)
        {
            var Guncelle = db.departmanlars.Find(id);
            return View(Guncelle);
        }
        [HttpPost]
        public IActionResult GuncelleDepartman(departmanlar department)
        {
            var deger = db.departmanlars.Find(department.id);
            deger.id=department.id;
            deger.departmanAd = department.departmanAd;
            deger.Aciklama= department.Aciklama;
            db.departmanlars.Update(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detay(int id)
        {
            var detay = db.departmanlars.FirstOrDefault(x => x.id == id);

            return View(detay);
        }

        //[HttpPost]
        //public IActionResult detay(departmanlar departman)
        //{
        //    var deger=db.departmanlars.Find(departman.id);
        //    deger.id = departman.id;
        //    deger.Aciklama=departman.Aciklama;
        //    return View();
        //}


    }
}
