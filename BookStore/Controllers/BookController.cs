using AutoMapper;
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
        private readonly IMapper _mapper;
        public BookController(BookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var bookEntities = _service.GetAllBooks(); /*----- Lazy Loading ----- */
            //var bookEntities = _service.GetBooksWithEagerLoading();
            var bookListModel = new List<BookViewModel>();
            foreach (var entity in bookEntities)
            {                
                var bookModel = _mapper.Map<BookViewModel>(entity);             
                bookListModel.Add(bookModel);
            }
            return View(bookListModel);
        }
        
    }
}
