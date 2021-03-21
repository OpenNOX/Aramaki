using Bogus;
using System.Collections.Generic;
using System.Linq;

namespace Aramaki.Services
{
    public class BogusService
    {
        public static IEnumerable<string> GetDomains()
        {
            return UtilityService.GetTypesInNamespace(typeof(Faker).Assembly, "Bogus.DataSets")
                .Where(type => type.IsPublic && type.IsSealed == false)
                .Select(type => type.Name);
        }
    }
}
