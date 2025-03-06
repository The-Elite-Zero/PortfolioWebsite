using Microsoft.AspNetCore.Mvc;
using Resume.Shared.Models;
using System.Text.Json;

namespace ResumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "project.json");

        [HttpGet]
        public IActionResult GetProject()
        {
            if (!System.IO.File.Exists(_filePath)) return NotFound("Project data not found.");

            var json = System.IO.File.ReadAllText(_filePath);
            var projectList = JsonSerializer.Deserialize<List<Project>>(json);
            return Ok(projectList);
        }
    }
}
