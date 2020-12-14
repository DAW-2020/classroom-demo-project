using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Entities
{
    public class Professor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserId { get; set; }

        public virtual List<Course> Courses { get; set; }
        public virtual User User { get; set; }
    }
}
