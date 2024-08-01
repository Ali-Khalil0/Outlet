using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KhalilsOutlet.Controllers
{
    public class DashboardController: Controller
    {
        public IActionResult Index()
        {
           return View("Index");
        }
    }
}
