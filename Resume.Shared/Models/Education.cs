namespace Resume.Shared.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Degree { get; set; } = string.Empty;
        public string? Field { get; set; } = string.Empty;   
        public int GraduationYear { get; set; }
    }
}
