﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public interface IDiplomaRepository
    {
        Diploma GetDiploma(int id);
        List<Diploma> GetDiplomas();
    }
}
