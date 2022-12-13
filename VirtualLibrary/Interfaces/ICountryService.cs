using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Interfaces
{
    public interface ICountryService 
    {
        public void Add(Country country);
        public List<Country> ToList();
        public Country Edit(Country country);
        public Country FindById(int id);
        public void Delete(int id);
       
    }
}
