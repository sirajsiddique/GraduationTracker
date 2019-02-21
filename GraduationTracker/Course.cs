using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Mark { get; set; }
        public int Credits { get; }
     }
}
