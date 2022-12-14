using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Models.Entitys
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual float height { get; set; }
        public virtual float width { get; set; }
        public virtual float Weight { get; set; }
        public virtual String IsbnCod { get; set; }
        public virtual int QntPages { get; set; }
        public virtual String Language { get; set; }
        public virtual Edition Edition { get; set; }
        public virtual float Price { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Author> Authors { get; set; }

    }
}
