﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MooshakPP.Models.Entities
{
    public class Submission
    {
        public int ID { get; set; }
        public int userID{ get; set; }
        public int milestoneID { get; set; }
        //public enum status { get; set; }
        public string fileURL { get; set; }
    }
}