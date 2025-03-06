using Resume.Shared.Models;

namespace ResumeWebsite.Client.Services
{
    public class ProjectService
    {
        private readonly HttpClient _http;

        public ProjectService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _http.GetFromJsonAsync<List<Project>>("api/project") ?? new List<Project>();
        }
    }
}