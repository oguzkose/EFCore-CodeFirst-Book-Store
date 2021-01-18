using BookStore.Models;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;
        public AuthorController(AuthorService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AuthorViewModel model)
        {
            var entities = new Author
            {
                Name=model.Name,
                Birthdate=model.Birthdate
            };
            _service.Add(entities);

            return RedirectToAction(nameof(Index), "Book");
        }
    }
}
