using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AITech.DataAccess.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {         
        }

   
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
