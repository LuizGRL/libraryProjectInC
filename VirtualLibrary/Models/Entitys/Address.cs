using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Models.Entitys
{
    public class Address
    {
        public virtual int Id { get; set; }
        public virtual String Cep { get; set; }
        public virtual String District { get; set; }
        public virtual String Block { get; set; }
        public virtual int Number { get; set; }
        public virtual String Street { get; set; }
        public virtual String Lot { get; set; }
        public virtual City City { get; set; }

    }
}
