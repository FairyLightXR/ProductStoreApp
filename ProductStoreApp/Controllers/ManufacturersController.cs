using Microsoft.AspNetCore.Mvc;
using ProductStoreApp.Data;
using ProductStoreApp.Models;
namespace ProductStoreApp.Controllers
{
    public class ManufacturersController:Controller
    {
        // Переменная контекста для доступа к базе данных
        private readonly ApplicationDbContext _db;

        // Внедряем зависимость ApplicationDbContext через конструктор
        public ManufacturersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // Создаем список записей категорий из базы данных
            IEnumerable<Manufacturers> ManufacturersList = _db.Manufacturers;
            // Возвращаем загруженный список в представление
            return View(ManufacturersList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Manufacturers cat)
        {

            _db.Manufacturers.Add(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Manufacturers cat)
        {

            _db.Manufacturers.Update(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            return View();
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var cat = _db.Manufacturers.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            _db.Manufacturers.Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
