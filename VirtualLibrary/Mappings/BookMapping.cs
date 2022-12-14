using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models.Entitys;

namespace VirtualLibrary.Mappings
{
    public class BookMapping: ClassMap<Book>
    {
        public BookMapping()
        {
            Table("Book");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name);
            Map(x => x.height);
            Map(x => x.IsbnCod);
            Map(x => x.QntPages);
            Map(x => x.Language);
            References(x => x.Edition);
            Map(x => x.Price);
            HasManyToMany(x => x.Genres).Cascade.All().Table("Book_Genre");
            HasManyToMany(x => x.Authors).Cascade.All().Table("Book_Author");



        }
    }
}
