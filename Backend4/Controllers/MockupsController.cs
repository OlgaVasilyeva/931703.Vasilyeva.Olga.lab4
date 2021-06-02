using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Backend4.Models.Controls;
using Microsoft.AspNetCore.Mvc;

namespace Backend4.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult SingUp()
        {
            return this.View();
        }

        public IActionResult SignUpAlreadyExists()
        {
            return this.View();
        }

        public IActionResult SignUpCredentials()
        {
            return this.View();
        }

        public IActionResult SignUpResult()
        {
            return this.View();
        }
    }
}