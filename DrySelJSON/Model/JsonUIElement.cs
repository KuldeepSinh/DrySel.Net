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
            UIElement uiElement =  new UIElement()
            {
                Key = Key,
                ElementID = ElementID
            };
            if (InputAction != null)
            {
                uiElement.InputAction = new ActionReflector().GetInstance(InputAction);
            }
            if (Assertion != null)
            {
                uiElement.Assertion = new AssertionReflector().GetInstance(Assertion);
            }
            return uiElement;
        }
    }
}
