using System.Linq;
using Aramaki.Entities;

namespace Aramaki.Database
{
    public static class DbInitializer
    {
        public static void Initialize(WebDbContext webDbContext)
        {
            if (webDbContext.Database.EnsureCreated() == false)
            {
                return;
            }

            webDbContext.Schemas.Add(new Schema { Id=1, Name="IMS OneRoster v1.1.1" });

            foreach (var table in new Table[]
                {
                    new Table { Id=1, SchemaId=1, Name="AcademicSession" },
                    new Table { Id=2, SchemaId=1, Name="Org" },
                })
            {
                webDbContext.Tables.Add(table);
            }

            webDbContext.SaveChanges();

            foreach (var field in new Field[]
                {
                    new Field { Id=1, TableId=1, Name="sourcedId", Domain="", Type="" },
                    new Field { Id=2, TableId=1, Name="status", Domain="Domain", Type="Enum" },
                    new Field { Id=3, TableId=1, Name="dateLastModified", Domain="Domain", Type="DateTime" },
                    new Field { Id=4, TableId=1, Name="metadata", Domain="Domain", Type="Guid" },
                    new Field { Id=5, TableId=1, Name="title", Domain="Domain", Type="Guid" },
                    new Field { Id=6, TableId=1, Name="startDate", Domain="Domain", Type="Guid" },
                    new Field { Id=7, TableId=1, Name="endDate", Domain="Domain", Type="Guid" },
                    new Field { Id=8, TableId=1, Name="type", Domain="Domain", Type="Guid" },
                    new Field { Id=9, TableId=1, Name="parent", Domain="Domain", Type="Guid" },
                    new Field { Id=10, TableId=1, Name="children", Domain="Domain", Type="Guid" },
                    new Field { Id=12, TableId=1, Name="schoolYear", Domain="Domain", Type="Guid" },
                    new Field { Id=13, TableId=2, Name="sourcedId", Domain="Domain", Type="Guid" },
                    new Field { Id=14, TableId=2, Name="status", Domain="Domain", Type="Enum" },
                    new Field { Id=15, TableId=2, Name="dateLastModified", Domain="Domain", Type="DateTime" },
                    new Field { Id=16, TableId=2, Name="metadata", Domain="Domain", Type="Guid" },
                    new Field { Id=17, TableId=2, Name="name", Domain="Domain", Type="Guid" },
                    new Field { Id=18, TableId=2, Name="type", Domain="Domain", Type="Guid" },
                    new Field { Id=19, TableId=2, Name="identifer", Domain="Domain", Type="Guid" },
                    new Field { Id=20, TableId=2, Name="parent", Domain="Domain", Type="Guid" },
                    new Field { Id=21, TableId=2, Name="children", Domain="Domain", Type="Guid" },
                })
            {
                webDbContext.Fields.Add(field);
            }

            webDbContext.SaveChanges();
        }
    }
}
