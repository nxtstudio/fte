using System;

namespace FTE.Hiring.Repos.Models
{
    public class PropertyValue
    {
        public Guid Id { get; set; }
        public Property Property { get; set; }
        public object Value { get; set; }
    }
}
