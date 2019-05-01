using System;
using System.Collections.Generic;

namespace FTE.Hiring.Repos.Models
{
    public class Property
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Required { get; set; }
        public DataType DataType { get; set; }
        public object DefaultValue { get; set; }
        public List<string> PossibleValues { get; set; }
    }
}
