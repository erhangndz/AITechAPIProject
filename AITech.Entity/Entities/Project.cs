using AITech.Entity.Entities.Common;

namespace AITech.Entity.Entities
{
    public class Project: BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }       
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
