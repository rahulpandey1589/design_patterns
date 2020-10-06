﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory.Concrete
{
    public class Beer : Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Beer is walking....");
        }
    }
}
