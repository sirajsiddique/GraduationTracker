﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public interface IRequirementRepository
    {
        Requirement GetRequirement(int id);
        List<Requirement> GetRequirements();   
    }
}
