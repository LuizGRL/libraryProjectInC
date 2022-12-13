using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class PublishCompanyMapping:ClassMap<PublishCompany>
    {
        public PublishCompanyMapping()
        {
            Table("PublishCompany");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
            References(x => x.Address);

        }
    }
}
