using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void Test1HasGraduated()
        {
            Diploma diploma = new Diploma();
            Student student = new Student();
            RequirementRepository requRepo = new RequirementRepository();

            diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
            };
          
            student = new Student
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
            };

            var actual = new GraduationTracker(requRepo, student, diploma).HasGraduated();
            bool expected = true;
  
            // Is Graduated
            Assert.AreEqual(expected, actual.Item1);
        }

        [TestMethod]
        public void Test1GraduationStanding()
        {
            Diploma diploma = new Diploma();
            Student student = new Student();
            RequirementRepository requRepo = new RequirementRepository();

            diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
            };

            student = new Student
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
            };

            var actual = new GraduationTracker(requRepo, student, diploma).HasGraduated();   
            STANDING expectedStanding = STANDING.MagnaCumLaude;

            // Standing
            Assert.AreEqual(expectedStanding, actual.Item2);
        }

        [TestMethod]
        public void Test2HasGraduated()
        {
            Diploma diploma = new Diploma();
            Student student = new Student();
            RequirementRepository requRepo = new RequirementRepository();

            diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
            };

            student = new Student
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
            };
      
            var actual = new GraduationTracker(requRepo, student, diploma).HasGraduated();
            bool expected = true;

            // Is Graduated
            Assert.AreEqual(expected, actual.Item1);
        }

        [TestMethod]
        public void Test2GraduationStanding()
        {
            Diploma diploma = new Diploma();
            Student student = new Student();
            RequirementRepository requRepo = new RequirementRepository();

            diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
            };

            student = new Student
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
            };

            var actual = new GraduationTracker(requRepo, student, diploma).HasGraduated();
            STANDING expectedStanding = STANDING.Average;

            // Standing
            Assert.AreEqual(expectedStanding, actual.Item2);
        }

        // This test is required since Student need to have which diploma studying
        [TestMethod]
        public void TestStudentHasDiploma()
        {
            Diploma diploma = new Diploma();
            Student student = new Student();
            RequirementRepository requRepo = new RequirementRepository();
      
            diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
            };

            student = new Student
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
            };

            int expected = student.DiplomaId;
            int actual = diploma.Id;

            Assert.AreEqual(expected, actual);
        }
    }
}
