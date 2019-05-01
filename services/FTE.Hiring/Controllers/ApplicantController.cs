using FTE.Hiring.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FTE.Hiring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Applicant>> Get()
        {
            return new List<Applicant>();
        }

        [HttpGet("{id}")]
        public ActionResult<Applicant> Get(Guid id)
        {
            return new Applicant();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Applicant value)
        {
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Applicant value)
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
