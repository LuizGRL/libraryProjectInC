using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class CountryMapping : ClassMap<Country>
    {
        public CountryMapping()
        {
            Table("Country");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
        }
    }
}
