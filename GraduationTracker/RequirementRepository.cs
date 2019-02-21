using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    // Based on Single Responsibility, this class is created
    public class RequirementRepository : IRequirementRepository
    {
        public Requirement GetRequirement(int id)
        {
            var requirements = GetRequirements();

            Requirement requirement = requirements.SingleOrDefault(x => x.Id == id);

            return requirement;
        }

        public List<Requirement> GetRequirements()
        {
            List<Requirement> reqList = new List<Requirement>();

            reqList.Add(
                new Requirement { Id = 100, Name = "Math", MinimumMark = 50, Courses = new List<Course>() { new Course() { CourseId = 1 } }, Credits = 1 }
             );
            reqList.Add(
                new Requirement { Id = 102, Name = "Science", MinimumMark = 50, Courses = new List<Course>() { new Course() { CourseId = 2 } }, Credits = 1 }
            );
            reqList.Add(
                new Requirement { Id = 103, Name = "Literature", MinimumMark = 50, Courses = new List<Course>() { new Course() { CourseId = 3 } }, Credits = 1 }
            );
            reqList.Add(
                new Requirement { Id = 104, Name = "Physichal Education", MinimumMark = 50, Courses = new List<Course>() { new Course() { CourseId = 4 } }, Credits = 1 }
            );

            return reqList;
        }
    }
}
