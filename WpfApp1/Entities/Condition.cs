﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Condition
    {
        public int ConditionId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
