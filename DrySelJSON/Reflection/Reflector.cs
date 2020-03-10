using DrySelJSON.Reflection.Abstractions;
using System;
using System.Reflection;

namespace DrySelJSON.Reflection
{
    public class Reflector<T> : IReflector<T> where T : class
    {
        private Assembly assembly;
        private string namesapce;

        public Reflector(string assemblyName, string namespaceName)
        {
            assembly = Assembly.Load(assemblyName);
            namesapce = namespaceName;
        }
        public T GetInstance(string instanceOf)
        {
            return CreateInstace(GetTypeFromName(instanceOf));
        }

        private T CreateInstace(Type type)
        {
            return (T)Activator.CreateInstance(type);
        }

        private Type GetTypeFromName(string instanceOf)
        {
            string fullyQualifiedClassName = GetFullyQualifiedClassName(instanceOf);
            return assembly.GetType(fullyQualifiedClassName, true, true);
        }

        private string GetFullyQualifiedClassName(string instanceOf)
        {
            if (string.IsNullOrEmpty(namesapce))
            {
                return instanceOf;
            }
            else
            {
                return $"{namesapce}.{instanceOf}";
            }
        }
    }
}

