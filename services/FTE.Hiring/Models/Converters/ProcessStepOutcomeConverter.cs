using R = FTE.Hiring.Repos.Models;

namespace FTE.Hiring.Models.Converters
{
    public static class ProcessStepOutcomeConverter
    {
        public static R.ProcessStepOutcome Convert(ProcessStepOutcome processStepOutcome)
        {
            return new R.ProcessStepOutcome
            {
                Id = processStepOutcome.Id,
                Title = processStepOutcome.Title,
            };
        }

        public static ProcessStepOutcome Convert(R.ProcessStepOutcome processStepOutcome)
        {
            return new ProcessStepOutcome
            {
                Id = processStepOutcome.Id,
                NextProcessStepId = processStepOutcome.NextProcessStep?.Id,
                Title = processStepOutcome.Title
            };
        }
    }
}
