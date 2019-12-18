using DrySelCore.Model;
using DrySelJSON.Reflection;

namespace DrySelJSON.Model
{
    public class JsonUIElement
    {
        public string JKey { get; set; }
        public string JElementID { get; set; }
        public string JInputAction { get; set; }
        public string JAssertion { get; set; }
        public UIElement GetUIElement()
        {
            return new UIElement()
            {
                Key = JKey,
                ElementID = JElementID,
                InputAction = new ActionReflector().GetInstance(JInputAction),
                Assertion = new AssertionReflector().GetInstance(JAssertion),
            };
        }
    }
}
