namespace TemplateProject.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddPersistence(configuration)
                .AddAuthenticationAndAuthorization(configuration)
                .AddExternalServices(configuration);

            return services;
        }

        public static IServiceCollection ConfigureDatabases(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            

            return services;
        }

        // =========================
        // Persistence (DB)
        // =========================
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDatabases(configuration);

            // Register repositories here later
            // services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }

        // =========================
        // Authentication
        // =========================
        public static IServiceCollection AddAuthenticationAndAuthorization(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure JWT settings from configuration

            // Configure authentication

            return services;
        }

        // =========================
        // External Services
        // =========================
        public static IServiceCollection AddExternalServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
