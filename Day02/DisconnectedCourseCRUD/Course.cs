using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedCourseCRUD
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }
        public int Topic_Id { get; set; }
    }
}
