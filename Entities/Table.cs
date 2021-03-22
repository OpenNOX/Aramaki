using System.Collections.Generic;

namespace Aramaki.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SchemaId { get; set; }
        public virtual ICollection<Field> Fields { get; set; }
    }
}
