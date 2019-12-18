using DrySelCore.Assertions.Abstractions;

namespace DrySelJSON.Reflection
{
    public class AssertionReflector : Reflector<IAssertion>
    {
        public AssertionReflector()
        {
            TypeNamePrefix = "DrySelCore.Assertions";
        }
        public AssertionReflector(string typeNamePrefix) : base(typeNamePrefix)
        {
        }

    }


}
