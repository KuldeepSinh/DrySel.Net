using DrySelCore.Assertions.Abstractions;

namespace DrySelJSON.Reflection
{
    public class AssertionReflector : Reflector<IAssertion>
    {
        public AssertionReflector() : this("DrySelCore", "DrySelCore.Assertions")
        {
        }
        public AssertionReflector(string assemblyName, string namespaceName) : base(assemblyName, namespaceName)
        {
        }
    }
}
