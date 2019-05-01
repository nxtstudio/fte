using FTE.Hiring.Models;
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
        [HttpGet]
        public ActionResult<IEnumerable<Process>> Get()
        {
            return new List<Process>
            {
                FakeData.Process
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Process> Get(Guid id)
        {
            return FakeData.Process;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Process value)
        {
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Process value)
        {
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}
