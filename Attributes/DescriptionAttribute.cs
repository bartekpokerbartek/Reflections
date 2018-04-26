using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
    class DescriptionAttribute : Attribute
    {
        public string Text;

        public DescriptionAttribute(string text)
        {
            Text = text;
        }
    }
}
