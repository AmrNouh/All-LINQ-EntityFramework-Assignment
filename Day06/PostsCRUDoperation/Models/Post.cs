using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostsCRUDoperation.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Body { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime PostDate { get; set; }

        [ForeignKey("PostBlog")]
        public int BlogId { get; set; }

        [ForeignKey("PostAuthor")]
        public int AuthorId { get; set; }

        // Nav Prop
        public virtual Blog? PostBlog { get; set; }

        public virtual Author? PostAuthor { get; set; }

        public virtual PostImage? Image { get; set; }
    }
}
