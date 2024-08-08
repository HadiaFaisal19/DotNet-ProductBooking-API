﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class Product
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public string Description { get; set; }
    }
}
