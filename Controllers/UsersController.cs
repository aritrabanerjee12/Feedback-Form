using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAppWithAPI.Controllers
{
    public class UsersController : Controller
    {
        //Users/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string uname, string password)
        {

            return View();
        }
    }
}
