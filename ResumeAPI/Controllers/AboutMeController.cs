using Microsoft.AspNetCore.Mvc;
using Resume.Shared.Models;
using System.Text.Json;

namespace ResumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMeController : ControllerBase
    {
        private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "aboutme.json");

        [HttpGet]
        public IActionResult GetAboutMe()
        {
            if (!System.IO.File.Exists(_filePath)) return NotFound("About Me data not found.");

            var json = System.IO.File.ReadAllText(_filePath);
            var aboutMe = JsonSerializer.Deserialize<AboutMe>(json);
            return Ok(aboutMe);
        }
    }
}
