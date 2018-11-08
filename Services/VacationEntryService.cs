using System.Collections.Generic;
using EmployeeVacationCalender.Models;
using EmployeeVacationCalender.Services.Interfaces;

namespace EmployeeVacationCalender.Services 
{
    public class VacationEntryService : IVacationEntryService
    {
        public VacationEntry GetVacationEntry(int entryId)
        {
            var entry = new VacationEntry();

            //get the entry by name

            return entry;
        }

        public VacationEntry UpdateVacationEntry(VacationEntry vacationEntryUpdate)
        {
            //find the corresponding entry

            var vacationEntry = GetVacationEntry(vacationEntryUpdate.VacationEntryId);
            //update values

            vacationEntry.FirstName = vacationEntryUpdate.FirstName;
            vacationEntry.LastName = vacationEntryUpdate.LastName;
            vacationEntry.StartDate = vacationEntryUpdate.StartDate;
            vacationEntry.EndDate = vacationEntryUpdate.EndDate;
            vacationEntry.VacationType = vacationEntryUpdate.VacationType;

            //save

            return vacationEntry;
        }

        public VacationEntry AddVacationEntry(VacationEntry vacationEntry)
        {
            //add vacation entry

            return vacationEntry;
        }

        public void DeleteVacationEntry(int vacationEntryId)
        {
            //find vacation entry by id
            //delete entry
        }


    }
}