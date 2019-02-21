using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public IList<Course> Courses { get; set; }
        public int DiplomaId { get; set; }
        public STANDING Standing { get; set; } = STANDING.None;
    }
}
