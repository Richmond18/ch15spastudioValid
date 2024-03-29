﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel )
        {
            if (ModelState.IsValid)
            { User newUser = new User
            {
                Password = addUserViewModel.VerifyPassword,
                
            };
                return View("~/User/Index", addUserViewModel);


            }
          
           
               
                return View("Add");
            }
        }

    }

