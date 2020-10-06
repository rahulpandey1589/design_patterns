using design_patterns.Factory.Factories;
using design_patterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory
{
    public static class FactoryStartup
    {
        public static void Main(string[] args)
        {
            IAnimal animalObj = new HerbivoresAnimalFactory();
            var responseClass = animalObj.CreateAnimal(AnimalEnum.Cow);

            responseClass.Walk();


            var responseClass1 = animalObj.CreateAnimal(AnimalEnum.Beer);

            responseClass1.Walk();


            Console.Read();

        }
    }
}
