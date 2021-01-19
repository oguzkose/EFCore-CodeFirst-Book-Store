using AutoMapper;
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
        private readonly IMapper _mapper;
        public AuthorController(AuthorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
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
        public IActionResult Add(AuthorInsertModel model)
        {
           
            var affectedRowsCount = _mapper.Map<Author>(model);
            _service.Add(affectedRowsCount);

            return View(model);
        }
    }
}
