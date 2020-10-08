using design_patterns.Factory.Concrete;
using design_patterns.Factory.Interfaces;

namespace design_patterns.Factory.Factories
{
    /// <summary>
    /// This class is a concrete creator class 
    /// </summary>
    public class CarnivoresAnimalFactory : AnimalFactory
    {
        public override Animal CreateAnimal(AnimalEnum animal)
        {
            Animal animalObj;

            switch (animal)
            {
                case AnimalEnum.Lion:
                    animalObj = new Lion();
                    break;

                default:
                    animalObj = new Lion();
                    break;
            }
            return animalObj;

        }
    }
}
