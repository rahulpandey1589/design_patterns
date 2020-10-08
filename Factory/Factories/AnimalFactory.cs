using design_patterns.Factory.Concrete;
using design_patterns.Factory.Interfaces;
using System;

namespace design_patterns.Factory.Factories
{
    /// <summary>
    ///  This class is Creator which creates concrete creator
    /// </summary>
    public abstract class AnimalFactory
    {
        public abstract Animal CreateAnimal(AnimalEnum animal);
    }
}
