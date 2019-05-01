using FTE.Hiring.Repos.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTE.Hiring.Repos
{
    public interface IProcessRepository
    {
        Task<IEnumerable<Process>> GetAllProcessesAsync();
        Task<Process> GetProcessByIdAsync(Guid id);
        Task<Process> CreateProcessAsync(Process process);
        Task<Process> UpdateProcessAsync(Process process);
        Task<Process> DeleteProcessByIdAsync(Guid id);
    }
}
