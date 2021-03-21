using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Aramaki.Services
{
    public static class UtilityService
    {
        public static IEnumerable<Type> GetTypesInNamespace(Assembly assembly, string nameSpace = "")
        {
            IEnumerable<Type> types = assembly.GetTypes();

            return nameSpace == string.Empty
                ? types
                : types.Where(type => string.Equals(type.Namespace, nameSpace, StringComparison.Ordinal));
        }
    }
}
