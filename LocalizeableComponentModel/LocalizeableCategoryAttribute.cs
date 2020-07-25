using System;
using System.ComponentModel;

namespace LocalizeableComponentModel
{
    public sealed class LocalizeableCategoryAttribute : CategoryAttribute
    {
        public LocalizeableCategoryAttribute(string key, Type resx) : base((string)resx.GetProperty(key).GetValue(resx))
        {

        }
    }
}
