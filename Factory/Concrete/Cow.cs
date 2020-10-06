using design_patterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory.Concrete
{
    public class Cow : Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Cow is walking....");
        }
    }
}
