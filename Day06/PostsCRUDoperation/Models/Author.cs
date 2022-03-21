using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostsCRUDoperation.Models
{
    public class Author
    {
        public Author()
        {
            AuthorPosts = new List<Post>();
        }

        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string? Name { get; set; }

        public int Age { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Passeword { get; set; }

        // Nav Prop
        public virtual ICollection<Post> AuthorPosts { get; set; }
    }
}
