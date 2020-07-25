using System;
using System.ComponentModel;

namespace LocalizeableComponentModel
{
    public sealed class LocalizeableDescriptionAttribute : DescriptionAttribute
    {
        public LocalizeableDescriptionAttribute(string key, Type resx) : base((string)resx.GetProperty(key).GetValue(resx))
        {

        }
    }
}
