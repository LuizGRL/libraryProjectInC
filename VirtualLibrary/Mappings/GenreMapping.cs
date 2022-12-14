using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class GenreMapping: ClassMap<Genre>
    {
        public GenreMapping()
        {
            Table("Genre");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
            HasManyToMany(x => x.Books).Cascade.All().Inverse().Table("Book_Genre");
        }
        
    }
}
