using System;
using System.ComponentModel;
using System.Reflection;

namespace LocalizeableComponentModel
{
    public sealed class LocalizeableCategoryAttribute : CategoryAttribute
    {
        public LocalizeableCategoryAttribute(string key, Type resx)
            : base((string)resx.GetProperty(key, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public).GetValue(resx))
        {

        }
    }
}
