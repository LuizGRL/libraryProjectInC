using Microsoft.AspNetCore.Mvc;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;
using VirtualLibrary.Repositories;
using VirtualLibrary.Services;

namespace VirtualLibrary.Controllers
{
    public class PersonsController : Controller
    {

        private readonly IPersonsService _service;


        public PersonsController(IPersonsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {


            return View(_service.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _service.Add(person);
                return RedirectToAction(nameof(Create));
            }
           
            return View(person);
        }
    }
}
