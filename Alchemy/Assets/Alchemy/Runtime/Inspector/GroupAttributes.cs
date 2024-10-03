namespace Alchemy.Inspector
{
    public sealed class GroupAttribute : PropertyGroupAttribute
    {
        public GroupAttribute() : base() { }
        public GroupAttribute(string groupPath, int groupOrder = -1) : base(groupPath, groupOrder) { }
    }

    public sealed class BoxGroupAttribute : PropertyGroupAttribute
    {
        public BoxGroupAttribute() : base() { }
        public BoxGroupAttribute(string groupPath, int groupOrder = -1) : base(groupPath, groupOrder) { }
    }

    public sealed class TabGroupAttribute : PropertyGroupAttribute
    {
        public TabGroupAttribute(string tabName) : base()
        {
            TabName = tabName;
        }

        public TabGroupAttribute(string groupPath, string tabName, int groupOrder = -1) : base(groupPath, groupOrder)
        {
            TabName = tabName;
        }

        public string TabName { get; }
    }

    public sealed class FoldoutGroupAttribute : PropertyGroupAttribute
    {
        public FoldoutGroupAttribute() : base() { }
        public FoldoutGroupAttribute(string groupPath, int groupOrder = -1) : base(groupPath, groupOrder) { }
    }

    public sealed class HorizontalGroupAttribute : PropertyGroupAttribute
    {
        public HorizontalGroupAttribute() : base() { }
        public HorizontalGroupAttribute(string groupPath, int groupOrder = -1) : base(groupPath, groupOrder) { }
    }

    public sealed class InlineGroupAttribute : PropertyGroupAttribute
    {
        public InlineGroupAttribute() : base() { }
        public InlineGroupAttribute(string groupPath, int groupOrder = -1) : base(groupPath, groupOrder) { }
    }
}