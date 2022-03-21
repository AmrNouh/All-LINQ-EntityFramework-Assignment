using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostsCRUDoperation.Models
{
    public class Blog
    {
        public Blog()
        {
            BlogPosts = new List<Post>();
        }

        [Key]
        public int BlogId { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? BlogDescription { get; set; }

        public virtual ICollection<Post> BlogPosts { get; set; }

    }
}
