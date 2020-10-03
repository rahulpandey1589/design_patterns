using design_patterns.Decorators.ConcretePizza;
using design_patterns.Decorators.Interfaces;
using design_patterns.Decorators.PizzaToppings;
using System;

namespace design_patterns.Decorators
{
    public class DecoratorStartUp
    {
        static void Main(string[] args)
        {
            DecoratorStartUp p
                 = new DecoratorStartUp();

            p.DecoratorsExample();

            Console.ReadLine();
        }

        public void DecoratorsExample()
        {
            IPizza pizza = new Pepporoni(new GreenPeppers(new ExtraCheese(new FarmHouse())));

            var cost = pizza.GetCost();

            var description = pizza.GetDescription();

            Console.WriteLine($"The description of pizza is {description} and cost of pizza is {cost}");
        }


    }
}
