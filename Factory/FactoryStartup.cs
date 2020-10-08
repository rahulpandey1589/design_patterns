using design_patterns.Factory.Factories;
using design_patterns.Factory.Interfaces;
using System;

namespace design_patterns.Factory
{
    /// <summary>
    ///  This the client application
    /// </summary>
    public static class FactoryStartup
    {
        public static void Main(string[] args)
        {
            AnimalFactory herbivoresAnimal = new HerbivoresAnimalFactory();
            var cowObj = herbivoresAnimal.CreateAnimal(AnimalEnum.Cow);
            cowObj.Walk();


            var beerObj = herbivoresAnimal.CreateAnimal(AnimalEnum.Beer);
            beerObj.Walk();


            AnimalFactory carnivoresAnimal = new CarnivoresAnimalFactory();
            var lionObj = carnivoresAnimal.CreateAnimal(AnimalEnum.Lion);
            lionObj.Walk();

            Console.Read();

        }
    }
}
