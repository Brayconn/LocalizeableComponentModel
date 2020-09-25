using System;
using System.ComponentModel;
using System.Reflection;

namespace LocalizeableComponentModel
{
    public sealed class LocalizeableDescriptionAttribute : DescriptionAttribute
    {
        public LocalizeableDescriptionAttribute(string key, Type resx)
            : base((string)resx.GetProperty(key, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public).GetValue(resx))
        {

        }
    }
}
