using Alchemy.Editor.Elements;
using UnityEditor.UIElements;

namespace Alchemy.Editor.Drawers
{
    public abstract class TrackSerializedObjectAttributeDrawer : AlchemyAttributeDrawer
    {
        public override void OnCreateElement()
        {
            if (TargetElement is MethodButton methodButton)
            {
                methodButton.button.clicked += OnInspectorChanged;
            }
            TargetElement.TrackSerializedObjectValue(SerializedObject, x =>
            {
                OnInspectorChanged();
            });

            OnInspectorChanged();
            TargetElement.schedule.Execute(() => OnInspectorChanged());
        }

        protected abstract void OnInspectorChanged();
    }
}