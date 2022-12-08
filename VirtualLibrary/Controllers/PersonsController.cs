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

namespace VirtualLibrary.Controllers
{
    public class PersonsController : Controller
    {
        private readonly ISession _session;
        private readonly IRepositoryModel<Person> _repository;

        public PersonsController(ISession session)
        {
            _session = SessionFactory.OpenSession;

        }
        public async Task<IActionResult> Index()
        {


            return View(await _session.Query<Person>().ToListAsync());
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

                    try
                    {
                        _repository.BeginTransaction();
                        _repository.Add(person);
                    }
                    catch
                    {
                        
                        _repository.RollBackTransaction();
                    }
                
            }
           
            return View(person);
        }
    }
}
