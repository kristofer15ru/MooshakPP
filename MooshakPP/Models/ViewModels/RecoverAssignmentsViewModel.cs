﻿using MooshakPP.Models.Entities;
using System.Collections.Generic;

namespace MooshakPP.Models.ViewModels
{
    public class RecoverAssignmentsViewModel
    {
        public List<Assignment> deletedAssignments { get; set; }
        public List<Course> courses { get; set; }
        public Course currentCourse { get; set; }
        public Assignment currentSelected { get; set; }
    }
}