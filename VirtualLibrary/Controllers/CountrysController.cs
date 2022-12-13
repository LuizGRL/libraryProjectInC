using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Controllers
{
    public class CountrysController : Controller
    {
        private readonly ICountryService _service;
        public CountrysController(ICountryService service)
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
        public async Task<IActionResult> Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _service.Add(country);
                return RedirectToAction(nameof(Create));

            }

            return View(country);
        }
    }
}
