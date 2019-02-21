using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public interface IStudent
    {
        int Id { get; set; }
        string StudentName { get; set; }
        int DiplomaId { get; set; }
        IList<Course> Courses { get; set; }
        STANDING Standing { get; set; } 
    }
}
