﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Register.IRegister
{
    internal interface IOrderLine
    {
        public bool Equals(object? obj);
        public string ToString();
        public int GetHashCode();
    }
}
