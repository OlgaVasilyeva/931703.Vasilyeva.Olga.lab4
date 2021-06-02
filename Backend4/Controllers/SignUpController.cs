using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Backend4.Models;
using Backend4.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend4.Controllers
{
    public class SignupController : Controller
    {
        private readonly ISignUpCheckService signupCheckService;

        public SignupController(ISignUpCheckService signupCheckService)
        {
            this.signupCheckService = signupCheckService;
        }
        public IActionResult SignUp()
        {
            this.ViewBag.AllMonths = this.GetAllMonths();
            this.ViewBag.AllYears = this.GetAllYear();
            this.ViewBag.AllDays = this.GetAllDay();
            var model = new SignUpViewModel();
            return this.View("SignUp", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(SignUpViewModel model, Boolean Action)
        {
            this.ViewBag.AllMonths = this.GetAllMonths();
            this.ViewBag.AllYears = this.GetAllYear();
            this.ViewBag.AllDays = this.GetAllDay();
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }
            if (Action)
            {
                if (this.signupCheckService.Registrate(model.Firstname, model.Lastname, model.Day, model.Month, model.Year, model.Gender) == false)
                {
                    return this.View("SignUpCredentials", new SignUpCredentialsViewModel
                    {
                        Firstname = model.Firstname,
                        Lastname = model.Lastname,
                        Day = model.Day,
                        Month = model.Month,
                        Year = model.Year,
                        Gender = model.Gender,
                        Exist = true
                    });
                }
                else
                {
                    model.Exist = true;
                    return this.View("SignUpAlreadyExists", model);
                }
            }
            return this.View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUpAlreadyExists(SignUpViewModel model, Boolean Action)
        {
            this.ViewBag.AllMonths = this.GetAllMonths();
            this.ViewBag.AllYears = this.GetAllYear();
            this.ViewBag.AllDays = this.GetAllDay();
            if (Action)
            {
                return this.View("SignUpCredentials", new SignUpCredentialsViewModel
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Day = model.Day,
                    Month = model.Month,
                    Year = model.Year,
                    Gender = model.Gender,
                    Exist = true
                });
            }
            return this.View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUpCredentials(SignUpCredentialsViewModel model, Boolean Action)
        {
            this.ViewBag.AllMonths = this.GetAllMonths();
            this.ViewBag.AllYears = this.GetAllYear();
            this.ViewBag.AllDays = this.GetAllDay();
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }
            if (Action == true)
            {
                return this.View("SignUpResult", model);
            }
            if (Action == false)
            {
                return this.View("SignUp", model);
            }
            return this.View("SignUpResult", model);
        }
        private SignUpMonth[] GetAllMonths()
        {
            return CultureInfo.InvariantCulture.DateTimeFormat.MonthNames
                .Select((x, i) => new SignUpMonth { Id = i + 1, Name = x })
                .Where(x => !String.IsNullOrEmpty(x.Name))
                .ToArray();
        }
        private Int32[] GetAllDay()
        {
            var days = new Int32[31];
            for (var i = 0; i < 31; i++)
            {
                days[i] = i + 1;
            }
            return days;
        }
        private Int32[] GetAllYear()
        {
            var year = new Int32[120];
            for (var i = 0; i <= 119; i++)
            {
                year[i] = i + 1900;
            }
            return year;
        }
    }
}
