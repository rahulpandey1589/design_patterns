using System;

namespace design_patterns.Factory.Concrete
{
    class Lion : Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Lion is walking....");
        }
    }
}
