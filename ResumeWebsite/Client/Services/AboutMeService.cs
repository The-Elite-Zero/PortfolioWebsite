using Resume.Shared.Models;

namespace ResumeWebsite.Client.Services
{
    public class AboutMeService
    {
        private readonly HttpClient _http;

        public AboutMeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<AboutMe> GetAboutMeAsync()
        {
            return await _http.GetFromJsonAsync<AboutMe>("api/aboutme") ?? new AboutMe();
        }
    }
}
