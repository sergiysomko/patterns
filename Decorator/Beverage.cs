﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";
        public virtual string GetDescription()
        {
            return this.Description;
        }
        public abstract double Cost();
    }
}
