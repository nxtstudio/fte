using FTE.Hiring.Repos.TableStorage.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FTE.Hiring.Repos.TableStorage.Internals
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class ServiceCollectionSetup
    {
        public static void AddPandoraServices(IServiceCollection services)
        {
            services.Add(ServiceDescriptor.Scoped<IVacancyRepository, VacancyRepository>());
        }
    }
}
