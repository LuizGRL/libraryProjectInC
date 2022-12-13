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



        }
    }
}
