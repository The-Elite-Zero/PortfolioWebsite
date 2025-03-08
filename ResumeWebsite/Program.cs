using ResumeWebsite.Client.Services;
using ResumeWebsite.Components;

var builder = WebApplication.CreateBuilder(args);
const string BASE_API_URL = "https://winstonwedgeworth-api.azurewebsites.net";


// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BASE_API_URL) });

// API Services
builder.Services.AddScoped<AboutMeService>();
builder.Services.AddScoped<EducationService>();
builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<SkillService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
