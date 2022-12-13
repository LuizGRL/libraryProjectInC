﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Models.Entitys
{
    public class Author 
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual List<Pseudonym> Pseudonyms { get; set; }


    }
}