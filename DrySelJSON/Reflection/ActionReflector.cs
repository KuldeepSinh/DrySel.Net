using DrySelCore.Actions.Abstractions;

namespace DrySelJSON.Reflection
{
    public class ActionReflector : Reflector<IAction>
    {
        public ActionReflector()
        {
            TypeNamePrefix = "DrySelCore.Actions";
        }
        public ActionReflector(string typeNamePrefix) : base(typeNamePrefix)
        {
        }

    }


}
