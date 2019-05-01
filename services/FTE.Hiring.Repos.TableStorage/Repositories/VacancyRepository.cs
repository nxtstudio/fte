using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FTE.Hiring.Repos.Models;

namespace FTE.Hiring.Repos.TableStorage.Repositories
{
    public class VacancyRepository : IVacancyRepository
    {
        public Task<Vacancy> CreateVacancyAsync(Vacancy vacancy)
        {
            throw new NotImplementedException();
        }

        public Task<Vacancy> DeleteVacancyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vacancy>> GetAllVacanciesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vacancy> GetVacancyByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Vacancy> UpdateVacancyAsync(Vacancy vacancy)
        {
            throw new NotImplementedException();
        }
    }
}
