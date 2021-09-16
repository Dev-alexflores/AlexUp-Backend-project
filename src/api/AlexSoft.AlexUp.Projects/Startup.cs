using AlexSoft.AlexUp.Core;
using AlexSoft.AlexUp.CoreInterfaces;
using AlexSoft.AlexUp.DAL;
using AlexSoft.AlexUp.DALInterfaces;
using AlexSoft.AlexUp.Projects;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace AlexSoft.AlexUp.Projects
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<IProjectsService, ProjectsService>();
            builder.Services.AddTransient<IRepository, Repository>();
        }
    }
}
