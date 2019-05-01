using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTE.Hiring.Repos.Models
{
    public class Vacancy
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Process Process { get; set; }
    }
}
