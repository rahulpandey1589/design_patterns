using design_patterns.AbstractFactory.Concrete;

namespace design_patterns.AbstractFactory.Factories
{
    public class WindowGUIFactory : GuiFactory
    {
        public override Button CreateButton()
        {
            return new WindowButton();
        }

        public override Checkbox CreateCheckbox()
        {
            return new WindowCheckbox();
        }
    }
}
