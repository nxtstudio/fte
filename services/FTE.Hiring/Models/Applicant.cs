using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTE.Hiring.Models
{
    public class Applicant
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public List<Question> Questions { get; set; }

        public List<ApplicantProcessStep> ProcessSteps { get; set; }
    }
}
