using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace News.Models
{
    public class NewsContext: DbContext  
    {
        public NewsContext():base("NewsContext")
        {

        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Type> Type { get; set; }
    }
}