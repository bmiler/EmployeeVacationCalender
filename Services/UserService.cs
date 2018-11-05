using System.Collections.Generic;
using EmployeeVacationCalender.Models;
using EmployeeVacationCalender.Services.Interfaces;

namespace EmployeeVacationCalender.Services
{
    public class UserService : IUserService
    {
        public UserViewModel GetUser(string fullName)
        {
            var user = new UserViewModel();

            //get the user by fullname.tolower()

            return user;
        }

        public List<UserViewModel> GetAllUsers()
        {
            var users = new List<UserViewModel>();

            //get all users, including their vacation entries

            return users;
        }

        public UserViewModel AddOrUpdateUser(UserViewModel user)
        {
            //get user by id
            //if user not exist add user
            //else update data
            //return updated/created

            return user;
        }
    }
}