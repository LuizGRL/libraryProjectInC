using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class EditionMapping:ClassMap<Edition>
    {
        public EditionMapping()
        {
            Table("Edition");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.EditionNumber);
            Map(x => x.PublishDate);
            References(x => x.PublishAddress);
            References(x => x.PublishCompany);
        }
    }
}
