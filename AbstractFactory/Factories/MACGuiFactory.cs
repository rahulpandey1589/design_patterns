using design_patterns.AbstractFactory.Concrete;
using System;

namespace design_patterns.AbstractFactory.Factories
{
    public class MACGuiFactory : GuiFactory
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }

        public override Checkbox CreateCheckbox()
        {
            return new MacCheckBox();
        }
    }
}
