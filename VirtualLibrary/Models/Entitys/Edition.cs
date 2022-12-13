using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Models.Entitys
{
    public class Edition
    {
        public virtual int Id { get; set; }
        public virtual int EditionNumber { get; set; }
        public virtual String PublishDate { get; set; }
        public virtual Address PublishAddress { get; set; }
        public virtual PublishCompany PublishCompany { get; set; }
    }
}
