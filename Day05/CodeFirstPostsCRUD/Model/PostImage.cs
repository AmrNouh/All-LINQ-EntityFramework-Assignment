using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstPostsCRUD.Model
{
    public class PostImage
    {
        [Key, ForeignKey("postImage")]
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public virtual Post postImage { get; set; }
    }
}
