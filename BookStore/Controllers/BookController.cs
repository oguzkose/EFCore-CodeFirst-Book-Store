using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _service;
        public BookController(BookService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var bookEntities = _service.GetAllBooks();
            var model = new List<BookViewModel>();
            foreach (var entity in bookEntities)
            {
                model.Add(new BookViewModel
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Author = entity.Author,
                    Publisher = entity.Publisher
                });
            }
            return View(model);
        }
    }
}
