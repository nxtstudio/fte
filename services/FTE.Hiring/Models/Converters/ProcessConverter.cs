using System.Linq;
using R = FTE.Hiring.Repos.Models;

namespace FTE.Hiring.Models.Converters
{
    public static class ProcessConverter
    {
        public static R.Process Convert(Process process)
        {
            return new R.Process
            {
                Id = process.Id,
                ProcessSteps = process.ProcessSteps?.Select(ProcessStepConverter.Convert).ToList(),
                Title = process.Title,
            };
        }

        public static Process Convert(R.Process process)
        {
            return new Process
            {
                Id = process.Id,
                ProcessSteps = process?.ProcessSteps.Select(ProcessStepConverter.Convert).ToList(),
                Title = process.Title,
            };
        }
    }
}
