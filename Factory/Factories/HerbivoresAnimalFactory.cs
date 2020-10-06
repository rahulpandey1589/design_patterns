using design_patterns.Factory.Concrete;
using design_patterns.Factory.Interfaces;

namespace design_patterns.Factory.Factories
{
    public class HerbivoresAnimalFactory : IAnimal
    {
        public Animal CreateAnimal(AnimalEnum animal)
        {
            Animal animalObj;

            switch(animal)
            {
                case AnimalEnum.Cow:
                    animalObj = new Cow();
                    break;

                case AnimalEnum.Beer:
                    animalObj = new Beer();
                    break;

                default:
                    animalObj = new Cow();
                    break;
            }
            return animalObj;
        }
    }
}
