using design_patterns.Decorators.Interfaces;

namespace design_patterns.Decorators.PizzaToppings
{
    public class GreenPeppers : ToppingsDecorator
    {
        public GreenPeppers(IPizza pizzaObj) : base(pizzaObj)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 1;  // adding cost of green peppers in base price of pizza
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Green Peppers";
        }
    }
}
