using System.Collections.Generic;
using EmployeeVacationCalender.Models.Enums;

namespace EmployeeVacationCalender.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public List<VacationEntryViewModel> VacationDays { get; set; }

        public string FullName { get {
            return this.FirstName + " " + this.LastName;
        }}
    }
}