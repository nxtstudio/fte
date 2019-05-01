using System;

namespace FTE.Hiring.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public string Anwser { get; set; }
    }
}
