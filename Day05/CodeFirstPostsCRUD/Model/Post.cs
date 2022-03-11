using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstPostsCRUD.Model
{
    public class Post
    {
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string Body { get; set; }
        public DateTime PostDateTime { get; set; }

        [Required, ForeignKey("author")]
        public int AutorId { get; set; }

        [Required, ForeignKey("blog")]
        public int BlogId { get; set; }

        //Navigation Property
        public virtual Author author { get; set; }

        public virtual Blog blog { get; set; }

        public virtual PostImage postImage { get; set; }
    }
}
