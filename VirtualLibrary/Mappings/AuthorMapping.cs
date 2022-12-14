using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class AuthorMapping:ClassMap<Author>
    {
        public AuthorMapping()
        {
            Table("Author");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
            HasMany(x => x.Pseudonyms).KeyColumn("Id");
            HasManyToMany(x => x.Books).Cascade.All().Inverse().Table("Book_Author");
        }
    }
}
