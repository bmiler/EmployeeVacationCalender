using System.ComponentModel;

namespace EmployeeVacationCalender.Models
{
    /// <summary>
    ///     Types of vacation an employee can take
    /// </summary>
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