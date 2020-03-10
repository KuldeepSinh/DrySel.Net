using DrySelCore.Actions.Abstractions;

namespace DrySelJSON.Reflection
{
    public class ActionReflector : Reflector<IAction>
    {
        public ActionReflector() : this("DrySelCore", "DrySelCore.Actions")
        {
        }
        public ActionReflector(string assemblyName, string namespaceName) : base(assemblyName, namespaceName)
        {
        }
    }
}
