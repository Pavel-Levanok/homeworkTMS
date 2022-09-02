using Microsoft.AspNetCore.Mvc;
using Homework13.Models;

namespace Homework13.Controllers
{
    
        public class BookController : Controller
        {
            public IActionResult Index()
            {
                BookViewModel book = new BookViewModel("Сказки", "Пушкин", 241);
                return View(book);
            }
        }
    
}
