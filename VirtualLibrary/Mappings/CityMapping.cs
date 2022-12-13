using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class CityMapping: ClassMap<City>
    {
        public CityMapping()
        {
            Table("City");
            Id(x => x.Id).Column("Id").GeneratedBy.Identity();
            Map(x => x.Name);
            References(x => x.State);
        }
    }
}
