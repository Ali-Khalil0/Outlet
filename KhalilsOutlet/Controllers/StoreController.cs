using KhalilsOutlet.Data;
using KhalilsOutlet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace KhalilsOutlet.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext context;

        public StoreController(ApplicationDbContext context)
        {
            this.context = context;
        }
       
        public IActionResult Index()
        {
            var prodcuts = context.Products.OrderByDescending(p=>p.Id).ToList();  

            
            return View(prodcuts);
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

        
      


        

    }
}
