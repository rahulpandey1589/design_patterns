using System;

namespace design_patterns.AbstractFactory.Concrete
{
    public class WindowCheckbox : Checkbox
    {
        public override string GetCheckboxType()
        {
            return "Window Checkbox Type";

        }
    }
}
