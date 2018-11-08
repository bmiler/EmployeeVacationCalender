using System.Collections.Generic;
using EmployeeVacationCalender.Models;

namespace EmployeeVacationCalender.Services.Interfaces
{
    public interface IVacationEntryService
    {
        VacationEntry GetVacationEntry(int entryId);

        VacationEntry UpdateVacationEntry(VacationEntry vacationEntry);

        VacationEntry AddVacationEntry(VacationEntry vacationEntry);

        void DeleteVacationEntry(int vacationEntryId);
    }
}