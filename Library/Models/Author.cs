﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? YearBorn { get; set; }
        public int? YearDied { get; set; }
    
    }
}