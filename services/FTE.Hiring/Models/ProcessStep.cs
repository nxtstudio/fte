using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTE.Hiring.Models
{
    public class ProcessStep
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Goal { get; set; }
        public string Description { get; set; }
        public List<Property> Properties { get; set; }
        public List<ProcessStepOutcome> PossibleOutcomes { get; set; }
    }
}
