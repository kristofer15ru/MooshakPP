﻿using MooshakPP.Models.Entities;
using System.Collections.Generic;
using System.Web;

namespace MooshakPP.Models.ViewModels
{
    public class CreateMilestoneViewModel
    {
        public List<Milestone> milestones { get; set; }
        public HttpPostedFileBase testCaseZip { get; set; }

        //currently selected
        public Assignment currentAssignment { get; set; }
        public Milestone currentMilestone { get; set; }
    }
}