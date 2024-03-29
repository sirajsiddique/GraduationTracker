﻿using System;
using System.Collections.Generic;

namespace GraduationTracker
{
    public class Requirement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinimumMark { get; set; }
        public int Credits { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
