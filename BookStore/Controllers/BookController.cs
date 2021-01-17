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
            var bookEntities = _service.GetAllBooks(); /*----- Lazy Loading ----- */
            //var bookEntities = _service.GetBooksWithEagerLoading();
            var bookListModel = new List<BookViewModel>();
            foreach (var entity in bookEntities)
            {
                var bookModel = new BookViewModel
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Publisher = entity.Publisher.Name
                };
                foreach (var item in entity.BookAuthors)
                {
                    bookModel.Author += item.Author.Name +" ";
                }
                bookListModel.Add(bookModel);
            }
            return View(bookListModel);
        }
    }
}
