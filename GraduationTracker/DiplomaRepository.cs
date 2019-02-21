using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    // Based on Single Responsibility, this class is created
    public class DiplomaRepository :IDiplomaRepository
    {
        public Diploma GetDiploma(int id)
        {
            var diplomas = GetDiplomas();

            Diploma diploma = diplomas.SingleOrDefault(x => x.Id == id);

            return diploma;
        }

        public List<Diploma> GetDiplomas()
        {
            List<Diploma> dipList = new List<Diploma>();

            dipList.Add(
                new Diploma
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
                });

            dipList.Add(
               new Diploma
               {
                   Id = 2,
                   Credits = 5,
                   Requirements = new List<Requirement>() { new Requirement() { Id = 100 }, new Requirement() { Id = 102 }, new Requirement() { Id = 103 }, new Requirement() { Id = 104 } }
               });

            return dipList;
        }

    }
}
