using Microsoft.AspNetCore.Mvc;
using Resume.Shared.Models;
using System.Text.Json;

namespace ResumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "skill.json");

        [HttpGet]
        public IActionResult GetSkill()
        {
            if (!System.IO.File.Exists(_filePath)) return NotFound("Skill data not found.");

            var json = System.IO.File.ReadAllText(_filePath);
            var skillList = JsonSerializer.Deserialize<List<Skill>>(json);
            return Ok(skillList);
        }
    }
}
