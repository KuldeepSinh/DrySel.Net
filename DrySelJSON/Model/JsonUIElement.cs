using DrySelCore.Model;
using DrySelJSON.Reflection;

namespace DrySelJSON.Model
{
    public class JsonUIElement
    {
        public string Key { get; set; }
        public string ElementID { get; set; }
        public string InputAction { get; set; }
        public string Assertion { get; set; }
        public UIElement GetUIElement()
        {
            return new UIElement()
            {
                Key = Key,
                ElementID = ElementID,
                InputAction = new ActionReflector().GetInstance(InputAction),
                Assertion = new AssertionReflector().GetInstance(Assertion),
            };
        }
    }
}
