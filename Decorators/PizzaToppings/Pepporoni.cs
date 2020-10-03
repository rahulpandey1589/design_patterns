using design_patterns.Decorators.Interfaces;

namespace design_patterns.Decorators.PizzaToppings
{
    public class Pepporoni : ToppingsDecorator
    {
        public Pepporoni(IPizza pizzaObj) : base(pizzaObj)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 3; // adding cost of Pepporoni to base price
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Pepporoni";
        }
    }
}