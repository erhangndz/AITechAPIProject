using AITech.Entity.Entities.Common;

namespace AITech.Entity.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }

        public IList<Project> Projects { get; set; }


    }
}
