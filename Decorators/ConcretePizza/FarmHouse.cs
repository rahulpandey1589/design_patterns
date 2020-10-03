using design_patterns.Decorators.Interfaces;
using System;

namespace design_patterns.Decorators.ConcretePizza
{
    public class FarmHouse : IPizza
    {
        public double GetCost()
        {
            return 2.0;  // base price of FarmHouse 
        }
         
        public string GetDescription()
        {
            return "Farm House";
        }
    }
}
