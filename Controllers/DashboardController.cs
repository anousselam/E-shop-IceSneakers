using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dotnet6MvcLogin.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        
        public IActionResult Display()
        {
            if (!User.Identity.IsAuthenticated)
            {

            }
            return View();
        }
        public IActionResult AccountDetails()
        {
           

            return View();
        }
    }
}
