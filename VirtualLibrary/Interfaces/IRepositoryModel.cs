using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Interfaces
{
    public interface IRepositoryModel<T> where T : class // classe generia onde t pode ser qualquer classe 
    {
        List<T> ToList();
        T SelectById(params object[] var);
        T Add(T obj);
        T Edit(T obj);
        T Remove(T obj);
        T RemoveById(params object[] var);
        public void CommitTransaction();
        
        public void RollBackTransaction();
        public void CloseSession();
        public void CloseTransaction();


        public void Dispose();

        public void BeginTransaction();
      

    }
}
