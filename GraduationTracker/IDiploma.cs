using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public interface IDiploma
    {
        int Id { get; set; }
        string DiplomaName { get; set; }
        int Credits { get; set; }
        IList<Requirement> Requirements { get; set; }
    }
}
