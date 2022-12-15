using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate;
using NHibernate;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Configuration;
using NHibernate.Tool.hbm2ddl;

namespace VirtualLibrary.Repositories
{
    public class SessionFactory
    {
        private static volatile ISessionFactory iSessionFactory; // Iniciando õ processo de conexão, a classe volatile é 
        private static object syncRoot = new Object();          //usada quando se existem muitas threads a serem tratadas

        public static ISession OpenSession
        {
            get
            {
                if (iSessionFactory == null)
                {
                    lock (syncRoot) // serve para dizer que as threads so podem acessar individualmente 
                    {
                        if (iSessionFactory == null)
                        {
                            iSessionFactory = BuildSessionFactory();
                        }
                    }
                }
                return iSessionFactory.OpenSession();
            }
        }
        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                 return Fluently.Configure().Database(PostgreSQLConfiguration.Standard.ConnectionString("User Id=postgres;Password=123;Host=localHost;Port=5432;DataBase=testeDB"))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true)) // usando o SchemaUpdate ele não vai dropar os dados da tabela 
                    .BuildSessionFactory();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            } 
        }
        }
      
}
