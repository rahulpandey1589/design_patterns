using System;

namespace design_patterns.AbstractFactory.Concrete
{
    public class MacCheckBox : Checkbox
    {
        public override string GetCheckboxType()
        {
            return "Mac Checkbox Type";

        }
    }
}
