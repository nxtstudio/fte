using FTE.Hiring.Repos.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FTE.Hiring.Repos
{
    public interface IVacancyRepository
    {
        Task<IEnumerable<Vacancy>> GetAllVacanciesAsync();
        Task<Vacancy> GetVacancyByIdAsync(Guid id);
        Task<Vacancy> CreateVacancyAsync(Vacancy vacancy);
        Task<Vacancy> UpdateVacancyAsync(Vacancy vacancy);
        Task<Vacancy> DeleteVacancyByIdAsync(Guid id);
    }
}
