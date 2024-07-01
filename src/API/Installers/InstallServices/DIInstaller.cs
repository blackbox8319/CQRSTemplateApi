using API.Installers.Interfaces;
using Application;
using Infrastructure;

namespace API.Installers.InstallServices
{
    public class DIInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddControllers();

            services.AddApplication();
            services.AddInfrastructure();
        }
    }
}
