using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstPostsCRUD.Model
{
    public class PostDbContext : DbContext
    {

        public PostDbContext()
            : base("name=PostDbContext")
        {
        }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<PostImage> PostImages { get; set; }
    }
}