using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class PseudonymMapping:ClassMap<Pseudonym>
    {
        public PseudonymMapping()
        {
            Table("Pseudonym");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
            References(x => x.Author).Column("author_id").Cascade.All();

        }
    }
}
