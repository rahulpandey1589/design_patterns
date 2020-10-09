using System;

namespace design_patterns.AbstractFactory.Concrete
{
    public class WindowButton : Button
    {
        public override string GetButtonType()
        {
            return "Window Button Type";
        }
    }
}
