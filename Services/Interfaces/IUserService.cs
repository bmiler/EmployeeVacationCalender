using System.Collections.Generic;
using EmployeeVacationCalender.Models;

namespace EmployeeVacationCalender.Services.Interfaces
{
    public interface IUserService
    {
        User GetUser(string fullName);

        List<User> GetAllUsers();

        User AddOrUpdateUser(User user);
    }
}