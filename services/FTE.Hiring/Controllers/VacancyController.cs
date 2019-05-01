using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FTE.Hiring.Models;
using FTE.Hiring.Models.Converters;
using FTE.Hiring.Repos;
using Microsoft.AspNetCore.Mvc;

namespace FTE.Hiring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        private readonly IVacancyRepository _vacancyRepository;

        public VacancyController(IVacancyRepository vacancyRepository)
        {
            _vacancyRepository = vacancyRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacancy>>> GetAsync()
        {
            var result = await _vacancyRepository.GetAllVacanciesAsync();
            return Ok(result.Select(VacancyConverters.Convert).ToList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vacancy>> GetAsync(Guid id)
        {
            var result = await _vacancyRepository.GetVacancyByIdAsync(id);
            return Ok(VacancyConverters.Convert(result));
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] Vacancy value)
        {
            var result = await _vacancyRepository.CreateVacancyAsync(VacancyConverters.Convert(value));
            return CreatedAtAction(nameof(GetAsync), new { id = result.Id }, result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(Guid id, [FromBody] Vacancy value)
        {
            var result = await _vacancyRepository.UpdateVacancyAsync(VacancyConverters.Convert(value));
            return Ok(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var result = await _vacancyRepository.DeleteVacancyByIdAsync(id);
            return Ok(result);
        }
    }
}
