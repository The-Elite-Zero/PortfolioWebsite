using Microsoft.AspNetCore.Mvc;
using Resume.Shared.Models;
using System.Text.Json;

namespace ResumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "education.json");

        [HttpGet]
        public IActionResult GetEducation()
        {
            if (!System.IO.File.Exists(_filePath)) return NotFound("Education data not found.");

            var json = System.IO.File.ReadAllText(_filePath);
            var educationList = JsonSerializer.Deserialize<List<Education>>(json);
            return Ok(educationList);
        }
    }
}
