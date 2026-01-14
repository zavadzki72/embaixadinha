using Embaixadinha.Data;
using Microsoft.EntityFrameworkCore;

namespace Embaixadinha.API.Configurations
{
    public static class EntityFrameworkConfiguration
    {
        public static void AddEntityFrameworkConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySqlConnection");

            services.AddDbContext<ApplicationContext>(x => x.UseNpgsql(connectionString));
        }
    }
}
