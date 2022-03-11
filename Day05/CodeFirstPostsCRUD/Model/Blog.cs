using System.Collections.Generic;

namespace CodeFirstPostsCRUD.Model
{
    public class Blog
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Describtion { get; set; }

        public virtual ICollection<Post> posts { get; set; }
    }
}