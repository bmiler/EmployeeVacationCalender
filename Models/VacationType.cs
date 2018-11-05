using System.ComponentModel;

namespace EmployeeVacationCalender.Models
{
    public enum VacationType
    {
        [DisplayName("Vacation Leave")]
        VacationLeave,

        [DisplayName("Sick Leave")]
        SickLeave,

        [DisplayName("Holiday")]
        Holiday
    }
}