using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public Table_1 usrtbl = new Table_1();

        [HttpPost]
        public ActionResult About(Table_1 Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Home","About");
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }      
            public IActionResult Index()
        {
            return View();
        }
    }
}
