﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal interface IGadget
    {
        public string _name { get; set; }
        public int _cost { get; set; }
        public bool _recharge { get; set; }
        public void Recharge();
    }
}
