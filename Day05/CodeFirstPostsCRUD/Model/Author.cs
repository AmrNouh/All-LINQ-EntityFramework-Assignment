using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstPostsCRUD.Model
{
    public class Author
    {

        public int Id { get; set; }

        [Required, MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [Column(TypeName ="int")]
        public int Age { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<Post> posts { get; set; }
    }
}