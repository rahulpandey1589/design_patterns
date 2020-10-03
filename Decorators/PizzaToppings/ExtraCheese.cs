using design_patterns.Decorators.Interfaces;

namespace design_patterns.Decorators.PizzaToppings
{
    public class ExtraCheese : ToppingsDecorator
    {
        public ExtraCheese(IPizza pizzaObj) : base(pizzaObj)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 2;  // adding cost of extra cheese in base price
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " , Extra Cheese";
        }
    }
}
