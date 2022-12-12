using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;
using VirtualLibrary.Repositories;

namespace VirtualLibrary.Services
{
    public class PersonsService:IPersonsService
    {
        private  IRepositoryModel<Person> _repository;
        

        public PersonsService(IRepositoryModel<Person> Repository)
        {
            _repository = Repository;
        }
         

        public void Add(Person person)
        {
         
                _repository.BeginTransaction();
                _repository.Add(person);
                
        }

        public List<Person> ToList()
        {
           return _repository.ToList();
        }

        public Person Edit(Person person)
        {
            _repository.Edit(person);
            return person;
        }

        public Person FindById(int var)
        {
            return _repository.SelectById(var);

            
        }

        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
