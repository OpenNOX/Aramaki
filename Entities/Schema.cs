using System.Collections.Generic;

namespace Aramaki.Entities
{
    public class Schema
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
    }
}
