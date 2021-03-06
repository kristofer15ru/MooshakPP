﻿using MooshakPP.Models.Entities;
using System.Collections.Generic;

namespace MooshakPP.Models.ViewModels
{
    public class ManageCourseViewModel
    {
        public List<Course> courses{ get; set; }
        public Course newCourse { get; set; }

        //currently selected
        public Course currentCourse { get; set; }
    }
}