using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PostsCRUDoperation.Models
{
    public class BlogPostDbContext : DbContext
    {
        public virtual DbSet<Blog>? Blogs { get; set; }
        public virtual DbSet<Author>? Authors { get; set; }
        public virtual DbSet<Post>? Posts { get; set; }
        public virtual DbSet<PostImage>? Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=.; Database=BlogPosts;Trusted_Connection=True;");
        }
    }
}
