using FTE.Hiring.Models;
using FTE.Hiring.Models.Converters;
using FTE.Hiring.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTE.Hiring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private readonly IProcessRepository _processRepository;

        public ProcessController(IProcessRepository processRepository)
        {
            _processRepository = processRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Process>>> GetAsync()
        {
            var result = await _processRepository.GetAllProcessesAsync();
            return Ok(result.Select(ProcessConverter.Convert).ToList());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Process>> GetAsync(Guid id)
        {
            var result = await _processRepository.GetProcessByIdAsync(id);
            return Ok(ProcessConverter.Convert(result));
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] Process value)
        {
            var result = await _processRepository.CreateProcessAsync(ProcessConverter.Convert(value));
            return Ok(ProcessConverter.Convert(result));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(Guid id, [FromBody] Process value)
        {
            var result = await _processRepository.UpdateProcessAsync(ProcessConverter.Convert(value));
            return Ok(ProcessConverter.Convert(result));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            var result = await _processRepository.DeleteProcessByIdAsync(id);
            return Ok(ProcessConverter.Convert(result));
        }
    }
}
