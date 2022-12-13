using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class AddressMapping:ClassMap<Address>
    {
        public AddressMapping()
        {
            Table("Address");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Street);
            Map(x => x.Number);
            Map(x => x.Lot);
            Map(x => x.District);
            Map(x => x.Block);
            Map(x => x.Cep);
            References(x => x.City);
        }
    }
}
