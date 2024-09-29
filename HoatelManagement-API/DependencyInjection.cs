using HostelManagement.Application;
using HostelManagement.Infrastructure;

namespace HoatelManagement_API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            services.AddApplicationDI().AddInfrastructureDI();
            return services;
        }
    }
}
