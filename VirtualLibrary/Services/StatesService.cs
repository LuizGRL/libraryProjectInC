using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Services
{
    public class StatesService : IStateService
    {
        IRepositoryModel<State> _repository;

        public StatesService(IRepositoryModel<State> Repository)
        {
            _repository = Repository;
        }
        public void Add(State state)
        {
            _repository.Add(state);
        }

        public void Delete(int id)
        {
            _repository.Remove(id);
        }

        public State Edit(State state)
        {
            return _repository.Edit(state);
        }

        public State FindById(int id)
        {
            return _repository.SelectById(id);
        }

        public List<State> ToList()
        {
            return _repository.ToList();
        }
    }
}
