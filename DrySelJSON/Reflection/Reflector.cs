using DrySelJSON.Reflection.Abstractions;
using System;

namespace DrySelJSON.Reflection
{
    public class Reflector<T> : IReflector<T> where T : class
    {
        public string TypeNamePrefix { get; set; }
        public Reflector()
        {
        }

        public Reflector(string assemblyName)
        {
            TypeNamePrefix = assemblyName;
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
            return Type.GetType(fullyQualifiedClassName, true, true);
        }

        private string GetFullyQualifiedClassName(string instanceOf)
        {
            if (string.IsNullOrEmpty(TypeNamePrefix))
            {
                return instanceOf;
            }
            else
            {
                return $"{TypeNamePrefix}.{instanceOf}";
            }
        }
    }
}

