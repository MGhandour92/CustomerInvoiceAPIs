﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public double UnitPrice { get; set; }
    }
}
