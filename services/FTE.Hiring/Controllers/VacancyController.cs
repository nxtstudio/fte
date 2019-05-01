using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FTE.Hiring.Models;
using Microsoft.AspNetCore.Mvc;

namespace FTE.Hiring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Vacancy>> Get()
        {
            return new List<Vacancy>
            {
                FakeData.Vacancy
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Vacancy> Get(int Guid)
        {
            return FakeData.Vacancy;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Vacancy value)
        {
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Vacancy value)
        {
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
