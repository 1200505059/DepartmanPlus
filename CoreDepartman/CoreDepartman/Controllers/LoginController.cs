using CoreDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class LoginController : Controller
    {
        Context db=new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GirisYap() { 
            
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin admin)
        {
            var degerler=db.admins.FirstOrDefault(x=>x.AdminUserName==admin.AdminUserName 
                              && 
            x.AdminPassword==admin.AdminPassword);
            if (degerler!=null)
            {
                var istek = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.AdminUserName),
                };
               
                return RedirectToAction("Index","department");
            }
            return RedirectToAction("Index","Login");

        }
    }
}
