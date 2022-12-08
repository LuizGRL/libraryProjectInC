using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Models.Entitys
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual String FullName { get; set; }
        public virtual String Cpf { get; set; }
        public virtual String BirthDate { get; set; }
        public virtual String Email { get; set; }
    }
}
