using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Web.DataAccsess;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            List<Product> products = await _context.Products.ToListAsync();
            List<ProductImage> productImages= await _context.ProductImages.ToListAsync();


            HomeVM vm = new()
            {
                Categories = categories,
                Products = products,
                ProductsImage = productImages,

            };

            return View(vm);
        }

   
    }
}