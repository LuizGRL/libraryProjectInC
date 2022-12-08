using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class PersonMapping  : ClassMap<Person>
    {
        public PersonMapping()
        {
            Id(x => x.Id);
            Map(x => x.Cpf);
            Map(x => x.Email);
            Map(x => x.FullName);
            Map(x => x.BirthDate);
        }

    }
}
