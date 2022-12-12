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
        public Person Edit(Person obj);
        public Person FindById(int var);

        public void Delete(int id);
    }
}
