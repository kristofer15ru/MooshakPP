﻿using MooshakPP.Models.ViewModels;
using MooshakPP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MooshakPP.Controllers
{
    public class AdminController : BaseController
    {
        private AdminService service = new AdminService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateCourse()
        {
            CreateCourseViewModel model = service.CreateCourse();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateCourse(FormCollection collection)
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(FormCollection collection)
        {
            return View();
        }

        public ActionResult ConnectUser()
        {
            AddConnectionsViewModel model = service.AddConnections();
            return View(model);
        }

        [HttpPost]
        public ActionResult ConnectUser(FormCollection collection)
        {
            return View();
        }
    }
}