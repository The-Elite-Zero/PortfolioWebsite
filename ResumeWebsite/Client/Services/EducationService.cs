using Resume.Shared.Models;

namespace ResumeWebsite.Client.Services
{
    public class EducationService
    {
        private readonly HttpClient _http;

        public EducationService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Education>> GetEducationAsync()
        {
            return await _http.GetFromJsonAsync<List<Education>>("api/education") ?? new List<Education>();
        }
    }
}
