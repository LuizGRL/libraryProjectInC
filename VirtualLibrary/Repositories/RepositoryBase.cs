using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Interfaces;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class // iniciando a classe com os metodos necessarios 
    {
        protected ISession _session = null;
        protected ITransaction _transaction = null; //usando para inicar a conexção com nhibernate 
        //Iniciado as seções e transações 
        public RepositoryBase()
        {
            _session = SessionFactory.OpenSession;
        }
        public RepositoryBase(ISession session)
        {
            _session = session;
        }
        // fim

        //Iniciado Gerenciamento de seções e transações 
        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }
        public void CommitTransaction()
        {
            _transaction.Commit();
            CloseTransaction();
            
        }
        public void RollBackTransaction()
        {
            _transaction.Rollback();
            CloseTransaction();
            CloseSession();
        }
        public void CloseSession()
        {
            _session.Close();
            _session.Dispose();
            _session = null;
        }
        public void CloseTransaction()
        {
            _transaction.Dispose();
            _transaction = null;
        }



        public void Dispose()
        {
            if (_transaction != null)
            {
                CommitTransaction();
            }
            if(_session != null)
            {
                _session.Flush();
                CloseSession();
            }
        }
        public virtual T Add(T obj)
        {
            _session.Save(obj);
            return obj;
        }


        public T Edit(T obj)
        {
            _session.SaveOrUpdate(obj);
            return obj;
         
        }

        public void Remove(int id )
        {
            var obj = SelectById(id);
            _session.Delete(obj);
            
        }

        public T RemoveById(params object[] var)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public List<T> ToList()
        {
            return _session.Query<T>().ToList();
        }

        public T SelectById(int var)
        {
            return _session.Get<T>(var);
        } 
    }
}
