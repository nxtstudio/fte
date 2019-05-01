using System;
using System.Collections.Generic;

namespace FTE.Hiring.Repos.Models
{
    public class ApplicantProcessStep
    {
        public Guid Id { get; set; }

        public ProcessStep ProcessStep { get; set; }

        public List<PropertyValue> Values { get; set; }

        public Guid AssignedTo { get; set; }

        public DateTime Deadline { get; set; }

        public ProcessStepOutcome Outcome { get; set; }

    }
}
