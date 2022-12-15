using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Controllers
{
    public class StatesController : Controller
    {
        private readonly IStateService _service;

        public StatesController(IStateService Service)
        {
            _service = Service;
        }
        public IActionResult Index()
        {
            return View(_service.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(State state)
        {
            if (ModelState.IsValid)
            {
                _service.Add(state);
                return RedirectToAction(nameof(Index));
            }
            return View(state);

        }
    }
}
