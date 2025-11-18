using AITech.Entity.Entities.Common;

namespace AITech.Entity.Entities
{
    public class Banner: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
