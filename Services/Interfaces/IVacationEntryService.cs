using System.Collections.Generic;
using EmployeeVacationCalender.Models;

namespace EmployeeVacationCalender.Services.Interfaces
{
    public interface IVacationEntryService
    {
        VacationEntryViewModel GetVacationEntry(int entryId);

        VacationEntryViewModel UpdateVacationEntry(VacationEntryViewModel vacationEntry);

        VacationEntryViewModel AddVacationEntry(VacationEntryViewModel vacationEntry);

        void DeleteVacationEntry(int vacationEntryId);
    }
}