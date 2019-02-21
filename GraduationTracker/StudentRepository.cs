using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    // Based on Single Responsibility, this class is created
    public class StudentRepository : IStudentRepository
    {
        public Student GetStudent(int id)
        {
            var students = GetStudents();

            Student student = students.SingleOrDefault(x => x.Id == id);

            return student;
        }

        public List<Student> GetStudents()
        {
            List<Student> stuList = new List<Student>();

            stuList.Add(
                  new Student
                  {
                      Id = 1,
                      DiplomaId = 1,
                      Courses = new Course[]
                           {
                                new Course{CourseId = 1, CourseName = "Math", Mark=95 },
                                new Course{CourseId = 2, CourseName = "Science", Mark=95 },
                                new Course{CourseId = 3, CourseName = "Literature", Mark=95 },
                                new Course{CourseId = 4, CourseName = "Physichal Education", Mark=95 }
                           }
                  }
              );

            stuList.Add(
                 new Student
                 {
                     Id = 2,
                     DiplomaId = 1,
                     Courses = new Course[]
                          {
                                new Course{CourseId = 1, CourseName = "Math", Mark=80 },
                                new Course{CourseId = 2, CourseName = "Science", Mark=80 },
                                new Course{CourseId = 3, CourseName = "Literature", Mark=80 },
                                new Course{CourseId = 4, CourseName = "Physichal Education", Mark=80 }
                          }
                 }
             );

            stuList.Add(
                new Student
                {
                    Id = 3,
                    DiplomaId = 1,
                    Courses = new Course[]
                         {
                                new Course{CourseId = 1, CourseName = "Math", Mark=50 },
                                new Course{CourseId = 2, CourseName = "Science", Mark=50 },
                                new Course{CourseId = 3, CourseName = "Literature", Mark=50 },
                                new Course{CourseId = 4, CourseName = "Physichal Education", Mark=50 }
                         }
                }
            );

            stuList.Add(
                new Student
                {
                    Id = 4,
                    DiplomaId = 1,
                    Courses = new Course[]
                         {
                                new Course{CourseId = 1, CourseName = "Math", Mark=40 },
                                new Course{CourseId = 2, CourseName = "Science", Mark=40 },
                                new Course{CourseId = 3, CourseName = "Literature", Mark=40 },
                                new Course{CourseId = 4, CourseName = "Physichal Education", Mark=40 }
                         }
                }
            );
            return stuList;
        }
    }
}
