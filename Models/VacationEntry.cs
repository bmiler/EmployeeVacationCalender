using System;
using EmployeeVacationCalender.Models.Enums;

namespace EmployeeVacationCalender.Models
{
    public class VacationEntry
    {
        public int VacationEntryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public VacationType VacationType { get; set; }
        public int UserId { get; set; }
    }
}