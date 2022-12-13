using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Services
{
    public class CountrysService : ICountryService
    {
        private IRepositoryModel<Country> _repository;

        public CountrysService(IRepositoryModel<Country> Repository)
        {
            _repository = Repository;
        }
        public void Add(Country country)

        {
            _repository.Add(country);
        }

        public void Delete(int id)
        {
            _repository.RemoveById(id);
        }

        public Country Edit(Country country)
        {
           return _repository.Edit(country);
           
        }

        public Country FindById(int id)
        {
            return _repository.SelectById(id);
        }

        public List<Country> ToList()
        {
            return _repository.ToList();
        }
    }
}
