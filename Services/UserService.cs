using System.Collections.Generic;
using EmployeeVacationCalender.Models;
using EmployeeVacationCalender.Services.Interfaces;

namespace EmployeeVacationCalender.Services
{
    public class UserService : IUserService
    {
        public User GetUser(string fullName)
        {
            var user = new User();

            //get the user by fullname.tolower()

            return user;
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            //get all users, including their vacation entries

            return users;
        }

        public User AddOrUpdateUser(User user)
        {
            //get user by id
            //if user not exist add user
            //else update data
            //return updated/created

            return user;
        }
    }
}