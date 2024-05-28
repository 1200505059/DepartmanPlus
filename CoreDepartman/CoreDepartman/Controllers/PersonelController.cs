using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        Context db=new Context();
    
        public IActionResult Index()
        {
            var degerler=db.personels.Include(i=>i.department).ToList();
            
            return View(degerler);
        }

        public IActionResult SilPersonel(int id)
        {
            var sil =db.personels.Find(id);
            db.personels.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            var departm = db.departmanlars.ToList();
            ViewBag.departm = departm;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(personel person)
        {
            db.personels.Add(person);
                db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GuncellePersonel(int id)
        {
            var departm = db.departmanlars.ToList();
            ViewBag.departm = departm;
            var guncelle = db.personels.Find(id);
            return View(guncelle);
        }
        [HttpPost]
        public IActionResult GuncellePersonel(personel person)
        {
            var deger=db.personels.Find(person.id);
            deger.id = person.id;
            deger.ad=person.ad;
            deger.soyad=person.soyad;
            deger.sehir=person.sehir;
            deger.departmentid=person.departmentid;
            db.personels.Update(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
