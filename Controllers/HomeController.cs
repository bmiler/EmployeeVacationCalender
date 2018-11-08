using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeVacationCalender.Models;
using EmployeeVacationCalender.Services.Interfaces;
using EmployeeVacationCalender.Models.Enums;

namespace EmployeeVacationCalender.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IVacationEntryService _vacationEntryService;

        HomeController(IUserService userService, IVacationEntryService vacationEntryService)
        {
            _userService = userService;
            _vacationEntryService = vacationEntryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _userService.GetAllUsers();

            //show calendar view
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new VacationEntry());
        }

        [HttpPost]
        public IActionResult Add(VacationEntry vacationEntry)
        {
            if(ModelState.IsValid)
            {
                var fullName = vacationEntry.FirstName.ToLower() + " " + vacationEntry.LastName.ToLower(); 

                var user = _userService.GetUser(fullName);

                if(user == null)
                {
                    user = new User
                    {
                        FirstName = vacationEntry.FirstName,
                        LastName = vacationEntry.LastName,
                        Role = UserRole.Employee,
                        VacationDays = new List<VacationEntry>()
                    };
                }


                vacationEntry = _vacationEntryService.AddVacationEntry(vacationEntry);

                user.VacationDays.Add(vacationEntry);

                _userService.AddOrUpdateUser(user);


                return Index();
            }
            else
            {
                return Error();
            }
        }

        [HttpGet]
        public IActionResult Edit(int vacationEntryId)
        {
            var vacationEntry = _vacationEntryService.GetVacationEntry(vacationEntryId);

            return View(vacationEntry);
        }

        [HttpPut]
        public IActionResult Edit(VacationEntry vacationEntry)
        {
            if(ModelState.IsValid)
            {
                var updatedVacationEntry = _vacationEntryService.UpdateVacationEntry(vacationEntry);

                return Index();
            }
            else
            {
                return Error();
            }           

        }

        [HttpDelete]
        public IActionResult Delete(int vacationEntryId)
        {
            _vacationEntryService.DeleteVacationEntry(vacationEntryId);

            return Index();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
