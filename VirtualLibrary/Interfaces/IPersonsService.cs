using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Interfaces
{
    public interface IPersonsService
    {
        public void Add(Person person);
        public List<Person> ToList();
    }
}
