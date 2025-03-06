using Resume.Shared.Models;

namespace ResumeWebsite.Client.Services
{
    public class SkillService
    {
        private readonly HttpClient _http;

        public SkillService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Skill>> GetSkillsAsync()
        {
            return await _http.GetFromJsonAsync<List<Skill>>("api/skill") ?? new List<Skill>();
        }

        public Dictionary<string, string> GetSkillCategories()
        {
            return Skill.SkillCategories;
        }
    }
}
