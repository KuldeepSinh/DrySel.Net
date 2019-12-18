using DrySelCore.Actions.Abstractions;

namespace DrySelCore.Model
{
    public class InputStep
    {
        public string ElementId { get; set; }
        public IAction Action { get; set; }
        public string InputData { get; set; }
    }
}
