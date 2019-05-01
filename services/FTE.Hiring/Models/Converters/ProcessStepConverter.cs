using System.Linq;
using R = FTE.Hiring.Repos.Models;

namespace FTE.Hiring.Models.Converters
{
    public static class ProcessStepConverter
    {
        public static R.ProcessStep Convert(ProcessStep processStep)
        {
            return new R.ProcessStep
            {
                Id = processStep.Id,
                Description = processStep.Description,
                Goal = processStep.Goal,
                PossibleOutcomes = processStep.PossibleOutcomes?.Select(ProcessStepOutcomeConverter.Convert).ToList(),
                Properties = processStep.Properties?.Select(PropertyConverter.Convert).ToList(),
                Title = processStep.Title,
            };
        }

        public static ProcessStep Convert(R.ProcessStep processStep)
        {
            return new ProcessStep
            {
                Id = processStep.Id,
                Description = processStep.Description,
                Goal = processStep.Goal,
                PossibleOutcomes = processStep.PossibleOutcomes?.Select(ProcessStepOutcomeConverter.Convert).ToList(),
                Properties = processStep.Properties?.Select(PropertyConverter.Convert).ToList(),
                Title = processStep.Title,
            };
        }
    }
}
