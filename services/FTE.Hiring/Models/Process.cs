using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTE.Hiring.Models
{
    public class Process
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<ProcessStep> ProcessSteps { get; set; }
    }
}
