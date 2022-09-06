using Microsoft.AspNetCore.Mvc;
using ProductStoreApp.Data;
using ProductStoreApp.Models;

namespace ProductStoreApp.Controllers
{
    public class CategoryController : Controller
    {
       private readonly ApplicationDbContext _db;
       public CategoryController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _db.Category;
            return View(categoryList);
        }
    }
}
