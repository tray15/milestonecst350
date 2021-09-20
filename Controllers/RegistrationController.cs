﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Milestone.Models;
using Milestone.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Milestone.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessRegistration(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.CreateUser(userModel))
            {
                return View("RegistrationSuccess", userModel);
            }
            else
            {
                return View("RegistrationFailure");
            }
        }
    }
}
