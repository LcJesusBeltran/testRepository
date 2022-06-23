using Microsoft.AspNetCore.Mvc;

namespace facebookLogin.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Logon()
        {
            return View();
        }
    }
}
