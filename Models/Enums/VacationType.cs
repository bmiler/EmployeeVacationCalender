using System.ComponentModel;

namespace EmployeeVacationCalender.Models.Enums
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