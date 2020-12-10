using doan_webfix.Data;
using doan_webfix.Models;
using doan_webfix.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doan_webfix.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomePagesController : Controller
    {
        public readonly ApplicationDbContext _db;
        public HomePageViewModel producthome { get; set; }
        public HomePagesController(ApplicationDbContext db)
        {
            _db = db;
            producthome = new HomePageViewModel()
            {
                newProduct = new List<Product>(),
                saleProduct = new List<Product>(),
            };
        }
        public IActionResult Index()
        {
            var newproduct = _db.Products.Include(m => m.ProductTypes).Where(m => m.isNew == true).ToList();
            producthome.newProduct = newproduct;
            var saleproduct = _db.Products.Include(m => m.ProductTypes).Where(m => m.newPrice != 0).ToList();
            producthome.saleProduct = saleproduct;
            return View(producthome);
        }
    }
}
