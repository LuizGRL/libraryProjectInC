using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class StateMapping:ClassMap<State>
    {
        public StateMapping()
        {
            Table("State");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
            Map(x => x.Uf);
            References(x => x.Country);
         
        }

    }
}
