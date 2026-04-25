using ResumeWebsite.Client.Services;

namespace ResumeWebsite.Startup
{

    public static class DependenciesConfig
    {
        const string BASE_API_URL = "https://winstonwedgeworth-api.azurewebsites.net";

        public static void AddDependencies(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddRazorComponents().AddInteractiveServerComponents();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BASE_API_URL) });

            // API Services
            builder.Services.AddScoped<AboutMeService>();
            builder.Services.AddScoped<EducationService>();
            builder.Services.AddScoped<ProjectService>();
            builder.Services.AddScoped<SkillService>();
        }
    }
}
