using System;

namespace FTE.Hiring.Repos.Models
{
    public class ProcessStepOutcome
    {
        public Guid Id { get; set; }
        public string Title { get; set; }       
        public ProcessStep NextProcessStep { get; set; }
    }
}
