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
    }

    public class Property
    {
        public string Title { get; set; }
        public bool Required { get; set; }
        public DataType DataType { get; set; }
        public object DefaultValue { get; set; }
        public List<string> PossibleValues { get; set; }
    }

    public enum DataType
    {
        String,
        Integer,
        Double,
        DateTime,

        PickList
    }
}
