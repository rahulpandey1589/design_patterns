using design_patterns.Decorators.Interfaces;
using System;

namespace design_patterns.Decorators.ConcretePizza
{
    public class PeppyPanner : IPizza
    {   
        public double GetCost()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
