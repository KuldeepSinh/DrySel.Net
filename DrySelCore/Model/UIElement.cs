using DrySelCore.Actions.Abstractions;
using DrySelCore.Assertions.Abstractions;

namespace DrySelCore.Model
{
    public class UIElement
    {
        public string Key { get; set; }
        public string ElementID { get; set; }
        public IAction InputAction { get; set; }
        public IAssertion Assertion { get; set; }
    }
}
