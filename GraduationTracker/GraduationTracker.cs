using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class GraduationTracker
    {
        private IRequirementRepository _reqRepo;
        private IDiploma _diploma;
        private IStudent _student;

        // Array type is replaced by List type
        public Tuple<bool, STANDING>  HasGraduated()
        {
            var credits = 0;
            var average = 0;
          
            foreach (Requirement req in _diploma.Requirements)
            {
                var requirement = _reqRepo.GetRequirement(req.Id);
          
                foreach (Course reqCourse in requirement.Courses)
                {
                    foreach (Course stuCourse in _student.Courses)
                    {                    
                        if (reqCourse.CourseId == stuCourse.CourseId)
                        {
                            average += stuCourse.Mark;

                            if (stuCourse.Mark > requirement.MinimumMark)
                            {
                                credits += requirement.Credits;
                            }
                        }
                    }                  
                }           
            }

            average = average / _student.Courses.Count;

            var standing = STANDING.None;

            if (average < 50)
                standing = STANDING.Remedial;
            else if (average < 80)
                standing = STANDING.Average;
            else if (average < 95)
                standing = STANDING.MagnaCumLaude;
            else
                standing = STANDING.MagnaCumLaude;

            switch (standing)
            {
                case STANDING.Remedial:
                    return new Tuple<bool, STANDING>(false, standing);
                case STANDING.Average:
                    return new Tuple<bool, STANDING>(true, standing);
                case STANDING.SumaCumLaude:
                    return new Tuple<bool, STANDING>(true, standing);
                case STANDING.MagnaCumLaude:
                    return new Tuple<bool, STANDING>(true, standing);

                default:
                    return new Tuple<bool, STANDING>(false, standing);
            } 
        }

        public GraduationTracker(IRequirementRepository requirement, IStudent student, IDiploma diploma)
        {
            _reqRepo = requirement;
            _student = student;
            _diploma = diploma;
        }
    }
}
