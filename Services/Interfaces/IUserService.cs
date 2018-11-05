using System.Collections.Generic;
using EmployeeVacationCalender.Models;

namespace EmployeeVacationCalender.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUser(string fullName);

        List<UserViewModel> GetAllUsers();

        UserViewModel AddOrUpdateUser(UserViewModel user);
    }
}