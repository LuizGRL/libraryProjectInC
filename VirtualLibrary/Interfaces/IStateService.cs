using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Interfaces
{
    public interface IStateService
    {
        public void Add(State state);
        public List<State> ToList();
        public State Edit(State state);
        public State FindById(int id);
        public void Delete(int id);
    }
}
