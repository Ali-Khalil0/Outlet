using KhalilsOutlet.Data;
using KhalilsOutlet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace KhalilsOutlet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;
       
        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
           
        }

        public IActionResult Index()
        {
            var products= context.Products.OrderByDescending(p=>p.Id).Take(4).ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Index", "Store");
            }

            return View(product);
        }
       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
