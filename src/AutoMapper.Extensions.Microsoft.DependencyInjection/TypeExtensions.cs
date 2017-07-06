using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Reflection
{
    static class TypeExtensions
    {
        public static IEnumerable<Type> GetDefinedTypes(this Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            Type[] array = new Type[types.Length];
            for (int i = 0; i < types.Length; i++)
            {
                Type typeInfo = types[i];
                array[i] = typeInfo;
            }
            return array;
        }
    }
}
