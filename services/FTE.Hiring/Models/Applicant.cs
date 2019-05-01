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
        public List<PropertyValue> Values { get; set; }
    }

    public class PropertyValue
    {
        public Guid Id { get; set; }
        public Property Property { get; set; }
        public object Value { get; set; }
    }

    public class Question
    {
        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public string Anwser { get; set; }
    }
}
