using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostsCRUDoperation.Models
{
    public class PostImage
    {
        [Key]
        public int ImageId { get; set; }

        public string? ImagePath { get; set; }

        [ForeignKey("ImagePost")]
        public int PostId { get; set; }

        // Nav Prop
        public virtual Post? ImagePost { get; set; }
    }
}
