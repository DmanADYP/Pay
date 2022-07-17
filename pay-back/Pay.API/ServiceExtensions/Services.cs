namespace Pay.API.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static string corsDev = "CorsDev";

        public static IServiceCollection CorsPolices(this IServiceCollection services)
        {
            return services.AddCors(policies =>
            {
                policies.AddPolicy(name: corsDev,
                    policy =>
                    {
                        policy.AllowAnyHeader();
                        policy.AllowAnyMethod();
                        policy.AllowAnyOrigin();
                    });
            });
        }
    }
}