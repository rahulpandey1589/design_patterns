using design_patterns.AbstractFactory.Concrete;

namespace design_patterns.AbstractFactory.Factories
{
    public abstract class GuiFactory
    {
        public abstract Button CreateButton();

        public abstract Checkbox CreateCheckbox();
    }
}
