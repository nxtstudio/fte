using FTE.Hiring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTE.Hiring
{
    public static class FakeData
    {
        private static Guid _processId = Guid.NewGuid();
        private static Guid _finalProcessId = Guid.NewGuid();

        static FakeData()
        {
            Vacancy = new Vacancy
            {
                Id = Guid.NewGuid(),
                Title = "Software Engineer",
                ProcessId = _processId
            };
            Process = new Process
            {
                Id = _processId,
                Title = "Software Engineer",
                ProcessSteps = new List<ProcessStep>
                {
                    new ProcessStep
                    {
                        Id = Guid.NewGuid(),
                        Title = "Title",
                        Description = "DEscription",
                        Goal = "Goal",
                        Properties = new List<Property>
                        {
                            new Property
                            {
                                Id = Guid.NewGuid(),
                                DataType = DataType.String,
                                Title = "Naam"
                            }
                        },
                        PossibleOutcomes = new List<ProcessStepOutcome>
                        {
                            new ProcessStepOutcome
                            {
                                Id = Guid.NewGuid(),
                                NextProcessStepId = _finalProcessId,
                                Title = "Yes"
                            },
                            new ProcessStepOutcome
                            {
                                Id = Guid.NewGuid(),
                                Title = "No"
                            }
                        }
                    },
                    new ProcessStep
                    {
                        Id = _finalProcessId,
                        Title = "Title 2",
                        Description = "DEscription 2",
                        Goal = "Goal",
                        Properties = new List<Property>
                        {
                            new Property
                            {
                                Id = Guid.NewGuid(),
                                DataType = DataType.String,
                                Title = "Naam"
                            }
                        },
                        PossibleOutcomes = new List<ProcessStepOutcome>
                        {
                            new ProcessStepOutcome
                            {
                                Id = Guid.NewGuid(),
                                Title = "Yes"
                            },
                            new ProcessStepOutcome
                            {
                                Id = Guid.NewGuid(),
                                Title = "No"
                            }
                        }
                    }
                }
            };
        }

        public static Vacancy Vacancy { get; }

        public static Process Process { get; }
    }
}
