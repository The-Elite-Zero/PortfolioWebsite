namespace Resume.Shared.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string? Company { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public string? Description { get; set; } = string.Empty;
        public string? TechStack { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        public string? GitHubLink { get; set; } = string.Empty;
        public string? ProjectLink { get; set; } = string.Empty;
    }
}
