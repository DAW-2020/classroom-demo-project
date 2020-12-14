using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Entities
{
    public class Course : BaseEntity
    {
        public int? ProfessorId { get; set; }

        public virtual Professor Professor { get; set; }
        public virtual List<CourseStudent> CourseStudents { get; set; }
    }
}
