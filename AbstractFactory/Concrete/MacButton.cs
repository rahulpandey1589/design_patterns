using System;

namespace design_patterns.AbstractFactory.Concrete
{
    public class MacButton : Button
    {
        public override string GetButtonType()
        {
            return "Mac Button Type";

        }
    }
}
