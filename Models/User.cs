using System.Collections.Generic;
using EmployeeVacationCalender.Models.Enums;

namespace EmployeeVacationCalender.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public List<VacationEntry> VacationDays { get; set; }

        public string FullName { get {
            return this.FirstName + " " + this.LastName;
        }}
    }
}