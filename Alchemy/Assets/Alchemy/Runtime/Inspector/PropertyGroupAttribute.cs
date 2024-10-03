using System;

namespace Alchemy.Inspector
{
    /// <summary>
    /// Base class of attributes for creating Group on Inspector
    /// </summary>
    public abstract class PropertyGroupAttribute : Attribute
    {
        public PropertyGroupAttribute()
        {
            GroupPath = string.Empty;
            GroupOrder = -1;
        }
        
        public PropertyGroupAttribute(string groupPath, int groupOrder = -1)
        {
            GroupPath = groupPath;
            GroupOrder = groupOrder;
        }

        public string GroupPath { get; }
        public int GroupOrder { get; }
    }
}