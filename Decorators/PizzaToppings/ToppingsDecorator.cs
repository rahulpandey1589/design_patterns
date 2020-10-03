using design_patterns.Decorators.Interfaces;

namespace design_patterns.Decorators.PizzaToppings
{
    public class ToppingsDecorator : IPizza
    {
        private readonly IPizza _pizzaObj;

        public ToppingsDecorator(IPizza pizzaObj)
        {
            this._pizzaObj = pizzaObj;
        }

        public virtual double GetCost()
        {
            return _pizzaObj.GetCost();
        }

        public virtual string GetDescription()
        {
            return _pizzaObj.GetDescription();
        }
    }
}
