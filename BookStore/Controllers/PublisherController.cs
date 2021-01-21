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
    public class PublisherController : Controller
    {
        private readonly PublisherService _service;
        private readonly IMapper _mapper;
        public PublisherController(PublisherService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(PublisherInsertViewModel model)
        {
            var entity = _mapper.Map<Publisher>(model);
            var affectedRowsCount = _service.Add(entity);
            ViewData["AffectedRowsCount"] = affectedRowsCount;
            return View(model);
        }
        public IActionResult Update(int id)
        {
            var entity = _service.GetById(id);
            var model = _mapper.Map<PublisherUpdateViewModel>(entity);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(PublisherUpdateViewModel model)
        {
            var entity = _mapper.Map<Publisher>(model);
            _service.Update(entity);

            return View(model);
        }

    }
}
