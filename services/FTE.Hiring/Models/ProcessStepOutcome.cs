using System;

namespace FTE.Hiring.Models
{
    public class ProcessStepOutcome
    {
        public Guid Id { get; set; }
        public string Title { get; set; }       
        public Guid? NextProcessStepId { get; set; }
    }
}
