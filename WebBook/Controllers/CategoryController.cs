using Microsoft.AspNetCore.Mvc;
using WebBook.data;
using WebBook.Models;

namespace WebBook.Controllers
{
    public class CategoryController : Controller
    {
       private readonly  ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> CategoryList = _db.Categories;
            return View(CategoryList);
        }

        //get action method
         public IActionResult Create()
        {
            return View();
        }  
        
         //Post action method
         //name [Required] (Validation) (Data Annotation) cant be null so if user pass null in name
         //it will through exception
         // and user is non technical his mind will be blown
         //So add Validations Server side (Controller me) & Client Side (View me) 
         [HttpPost]
         [ValidateAntiForgeryToken]
         public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }  
        
         
       
    }
}
